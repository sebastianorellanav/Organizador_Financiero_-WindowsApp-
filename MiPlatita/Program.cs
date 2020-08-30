using MiPlatita.BackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPlatita
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Archivos a = new Archivos();
            if (a.comprobarUsuario()) //hay usuario
            {
                Application.Run(new FormDashboard());
            }
            else //no hay usuario
            {
                Application.Run(new FormBienvenida());
            }
        }
    }
}
