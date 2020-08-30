using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPlatita
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eventoIngresar(object sender, EventArgs e)
        {
            String nombre = boxName.Text;
            //escribir en nombre en un archivo de texto
            var path = Path.GetFullPath("../../DatosUsuario/nombreUsuario.txt");
            TextWriter tsw = new StreamWriter(path);
            //escribiendo en el archivo.
            tsw.WriteLine(nombre);
            //cerrar el archivo.
            tsw.Close();
            Form dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();

        }

        private void eventoCerrarForm(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
