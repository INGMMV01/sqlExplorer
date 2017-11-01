using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using Microsoft.ApplicationBlocks.Data;

namespace SqlExplorer
{
    public enum Entorno
    {
        D,
        P,
        E
    }

    public class DataBase
    {
        const string DefinitionPattern = "sp_helptext N'{0}'";

        const string SelectPattern = 
            "SELECT {0} " +
            "FROM {1}.INFORMATION_SCHEMA.ROUTINES " +
            "WHERE ROUTINE_TYPE = 'PROCEDURE' " + 
            "AND ROUTINE_CATALOG='{1}' ";

        static class Fields 
        {
            public static string
                Catalog = "ROUTINE_CATALOG",
                Schema = "ROUTINE_SCHEMA",
                Name = "ROUTINE_NAME",
                Definition = "ROUTINE_DEFINITION",
                Created = "CREATED",
                LastModified = "LAST_ALTERED";
        }

        public DataBase(string name)
        {
            Entorno e;
            if (Enum.TryParse<Entorno>(name.Substring(name.Length - 1), out e))
            {
                this.Entorno = e;
            }
            else
            {
                throw new ArgumentOutOfRangeException("name");
            }
            CatalogName = name.Remove(name.Length - 1); ;

            ConnectionString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public string CatalogName
        {
            get;
            private set;
        }

        public Entorno Entorno
        {
            get;
            private set;
        }

        public string ConnectionString
        {
            get;
            private set;
        }

        public string[] GetSP(string filter)
        {
            StringBuilder query = GetSelect(Fields.Schema, Fields.Name);

            if (filter != null)
            {
                query
                    .Append("AND ")
                    .Append(Fields.Name)
                    .AppendFormat(" LIKE '{0}%'", filter.Replace("'", ""));
            }
            query.Append("ORDER BY ").Append(Fields.Name);
            
            List<string> list = new List<string>();
            using (Impersonator imp = new Impersonator())
            {
                imp.Impersonate();

                using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, query.ToString()))
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0) + "." + reader.GetString(1));
                    }
                    reader.Close();
                }
            }

            return list.ToArray();
        }

        public string GetSPDefinition(string name)
        {
            if (name == null) throw new ArgumentNullException("name");

            StringBuilder query = 
                new StringBuilder()
                    .AppendFormat(DefinitionPattern, name);

            StringBuilder sb = new StringBuilder();

            using (Impersonator imp = new Impersonator())
            {
                imp.Impersonate();

                using (IDataReader dr = SqlHelper.ExecuteReader(ConnectionString, CommandType.Text, query.ToString()))
                {                    
                    while (dr.Read())
                    {
                        sb.Append(dr.GetString(0));
                    }
                    dr.Close();
                }
            }

            return sb.ToString();
        }

        private StringBuilder GetSelect(params string[] fields)
        {
            return new StringBuilder().AppendFormat(SelectPattern, string.Join(", ", fields), CatalogName);
        }
    }
}
