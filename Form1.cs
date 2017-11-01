using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlExplorer
{
    public partial class Form1 : Form
    {
        string[] allPA = null;
        string currentFiltro = null;

        public Form1()
        {
            InitializeComponent();
        }

        DataBase DataBase { get; set; }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionaBBDD((ToolStripMenuItem)sender, null);
        }

        private void entornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionaBBDD(null, (ToolStripMenuItem)sender);
        }

        private void SeleccionaBBDD(ToolStripMenuItem bbddStrip, ToolStripMenuItem entornoStrip)
        {
            foreach (ToolStripMenuItem tsi in conectarToolStripMenuItem.DropDownItems)
            {
                if (bbddStrip == null)
                {
                    if (tsi.Checked)
                    {
                        bbddStrip = tsi;
                        break;
                    }
                }
                else
                {
                    tsi.Checked = tsi == bbddStrip;
                }
            }

            foreach (ToolStripMenuItem tsi in entornoToolStripMenuItem.DropDownItems)
            {
                if (entornoStrip == null)
                {
                    if (tsi.Checked)
                    {
                        entornoStrip = tsi;
                        break;
                    }
                }
                else
                {
                    tsi.Checked = tsi == entornoStrip;
                }
            }

            entornoToolStripMenuItem.Enabled = true;

            string dbname = (string)bbddStrip.Tag + (string)entornoStrip.Tag;
            
            Application.DoEvents();

            this.Enabled = false;
            this.SuspendLayout();

            InitDataBase(dbname);

            this.Enabled = true;
            this.ResumeLayout();
        }

        private void InitDataBase(string dbname)
        {
            
            DataBase = new DataBase(dbname);
            allPA = DataBase.GetSP(null);
            LoadList(FiltraPA(currentFiltro));            
        }

        private void LoadList(string[] list)
        {
            lista.SuspendLayout();
            lista.Items.Clear();
            lista.Items.AddRange(list);
            lista.ResumeLayout();
        }

        private string[] FiltraPA(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro)) return allPA;
            string f = "." + filtro;
            return allPA.Where(s => s.IndexOf(f, StringComparison.InvariantCultureIgnoreCase) > -1).ToArray();
        }

        private void tFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentFiltro = tFiltro.Text;
            if (Char.IsLetterOrDigit(e.KeyChar)) currentFiltro += e.KeyChar;
            currentFiltro = currentFiltro.Trim();
            if (string.IsNullOrWhiteSpace(currentFiltro)) currentFiltro = null;

            LoadList(FiltraPA(currentFiltro));
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            texto.Text = DataBase.GetSPDefinition(lista.SelectedItem.ToString());
        }
        
    }
}
