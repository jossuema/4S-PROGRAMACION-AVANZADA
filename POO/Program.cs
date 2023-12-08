using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAdminPersona());

            Persona persona = new Persona(1, "0706209905", "Josue", "Malla", 'M', new DateTime(2004, 10, 28), "Soltero");
            persona.Codigo = 10;
        }
    }
}
