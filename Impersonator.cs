using System;
using System.Text;
using System.Security.Principal;
using System.Runtime.InteropServices;

namespace SqlExplorer
{
    public sealed class Impersonator : IDisposable
    {
        readonly string userName, password;
        WindowsIdentity id;
        IntPtr token = IntPtr.Zero;
        WindowsImpersonationContext impersonatedUser = null;

        static Impersonator()
        {
            
        }

        public Impersonator()
            : this("MTSRPOS", PasswordUsuario("MTSRPOS"))
        {

        }

        public Impersonator(string usrname, string pwd)
        {
            userName = usrname;
            password = pwd;
        }

        #region WinAPI

        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool LogonUser(
          string principal,
          string authority,
          string password,
          LogonSessionType logonType,
          LogonProvider logonProvider,
          out IntPtr token);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);

        enum LogonSessionType : uint
        {
            Interactive = 2,
            Network,
            Batch,
            Service,
            NetworkCleartext = 8,
            NewCredentials
        }

        enum LogonProvider : uint
        {
            Default = 0, // default for platform (use this!)
            WinNT35,     // sends smoke signals to authority
            WinNT40,     // uses NTLM
            WinNT50      // negotiates Kerb or NTLM
        }
        #endregion

        public bool Impersonate()
        {
            // Obtengo un token con el usuario administrador, para obtener permisos
            bool result = LogonUser(userName,
                                    null,
                                    password,
                                    LogonSessionType.Interactive,
                                    LogonProvider.Default,
                                    out token);
            if (result)
            {
                // Me impersono
                id = new WindowsIdentity(token);
                impersonatedUser = id.Impersonate();
            }

            return result;
        }

        public void Revert()
        {
            // Stop impersonation and revert to the process identity
            if (impersonatedUser != null)
            {
                impersonatedUser.Undo();
                impersonatedUser = null;
            }
            // Free the token
            if (token != IntPtr.Zero) 
            {
                CloseHandle(token);
                token = IntPtr.Zero;
            }
            if(id != null) 
            {
                id.Dispose();    
                id = null;
            }
        }
        
        public void Dispose()
        {
            Revert();
        }

        #region Generación de password
        /// <summary>
        /// </summary>
        /// <param name="CadenaIn"></param>
        /// <param name="CadenaOut"></param>
        /// <returns></returns>
        [DllImport(@"C:\ApplicationCenter\CGAL\WCRIPTO\WCriptoDll.dll", EntryPoint = "Encripta",
                    ExactSpelling = false)]
        private static extern int Encripta(String CadenaIn, StringBuilder CadenaOut);

        /// <summary>
        /// Genera una clave para un nuevo usuario de aplicación
        /// </summary>
        /// <param name="strUsuario"></param>
        /// <returns></returns>
        private static string PasswordUsuario(string strUsuario)
        {
            long lngChk = 0;
            StringBuilder sbVALOR = new StringBuilder();
            String strPassword;
            int intRes;

            //Calculamos el Valor que se pasará a la función Encripta a partir del
            //Usuario que se recibe como parámetro
            for (int i = 0; i < strUsuario.Length; i++)
            {
                char chrCaracter = Convert.ToChar(strUsuario.Substring(i, 1));
                lngChk += Convert.ToInt32(chrCaracter);
            }

            //Metemos un espacio en blanco delante del valor y le metemos 14 espacios al final
            sbVALOR.Insert(0, " " + lngChk.ToString().PadRight(lngChk.ToString().Length + 14, ' '));

            //Llamamos a la función Encripta de la DLL WCriptoDll
            intRes = Encripta(strUsuario, sbVALOR);

            //Asignamos a la variable password el valor de la variable VALOR con espacios 
            //en blanco añadidos hasta que iguale la longitud de la variable VALOR
            strPassword = sbVALOR.ToString();
            if (intRes == 0)
            {
                Exception ex = new Exception("Error calculando clave de usuario: " + intRes.ToString());

                throw ex;
            }

            return strPassword;
        }

        #endregion

    }
}
