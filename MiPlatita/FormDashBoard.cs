using MiPlatita.BackEnd;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MiPlatita
{
    public partial class FormDashboard : Form
    {
        private List<Transaccion> transacciones;
        private String NombreUsuario;

        public FormDashboard()
        {
            InitializeComponent();
            var path = Path.GetFullPath("../../DatosUsuario/nombreUsuario.txt");
            this.NombreUsuario = File.ReadAllText(path);
            TituloForm.Text = "Hola, " + this.NombreUsuario;
            transacciones = new Transaccion().obtenerTodasTransacciones();
            InitializeDataGridView();
            initializeCalendar();
            
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        private void botonAnadirGatos_Click(object sender, EventArgs e)
        {
            Form formAnadirGasto = new FormAnadirGasto();
            formAnadirGasto.Show();
            this.Hide();
        }

        private void botonAñadirIngresos_Click(object sender, EventArgs e)
        {
            Form formAnadirIngreso = new FormAnadirIngreso();
            formAnadirIngreso.Show();
            this.Hide();
        }

        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a
            // column count.
            gridViewUltimasTransacciones.ColumnCount = 5;
            gridViewUltimasTransacciones.ColumnHeadersVisible = true;
            gridViewUltimasTransacciones.Size = new Size(523,261);
            
            //AdjustDataGridViewSizing();

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellsStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.DarkBlue;
            columnHeaderStyle.Font =
                new Font("Arial", 10, FontStyle.Bold);
            gridViewUltimasTransacciones.ColumnHeadersDefaultCellStyle =
                columnHeaderStyle;
            cellsStyle.Font = new Font("Arial", 9);
            gridViewUltimasTransacciones.DefaultCellStyle = cellsStyle;

            // Set the column header names.
            gridViewUltimasTransacciones.Columns[0].Name = "#";
            gridViewUltimasTransacciones.Columns[0].Width = 35;
            gridViewUltimasTransacciones.Columns[1].Name = "Nombre";
            gridViewUltimasTransacciones.Columns[1].Width = 200;
            gridViewUltimasTransacciones.Columns[2].Name = "Fecha";
            gridViewUltimasTransacciones.Columns[2].Width = 120;
            gridViewUltimasTransacciones.Columns[3].Name = "Abono";
            gridViewUltimasTransacciones.Columns[3].Width = 80;
            gridViewUltimasTransacciones.Columns[4].Name = "Deposito";
            gridViewUltimasTransacciones.Columns[4].Width = 85;

            int count = transacciones.Count();
            // Populate the rows.
            if ( count != 0)
            {
                if(count > 5)
                { 
                    count = 5; 
                }
                for(int i = 0; i<count; i++)
                {
                    string[] row1;
                    if (transacciones[i].tipo.Equals("ingreso"))
                    {
                        row1 = new string[]{transacciones[i].id.ToString(),
                                            transacciones[i].donde, transacciones[i].cuando.ToString("dd-MM-yyyy"),
                                            "$"+transacciones[i].monto.ToString(), "$0" };
                    }
                    else
                    {
                        row1 = new string[]{transacciones[i].id.ToString(),
                                            transacciones[i].donde, transacciones[i].cuando.ToString("dd/MM/yyyy"),
                                            "$0","$"+transacciones[i].monto.ToString()};
                    }

                    gridViewUltimasTransacciones.Rows.Add(row1);
                }
            }  
        }

        private void initializeCalendar()
        {
            foreach(Transaccion t in transacciones)
            {
                calendario.AddBoldedDate(t.cuando);
            }
        }

        private void DateSelectedClick(object sender, DateRangeEventArgs e)
        {
            DateTime fecha = e.Start;
            List<Transaccion> actuales = new List<Transaccion>();
            foreach(Transaccion t in transacciones)
            {
                if(t.cuando.ToString("MM/dd/yyyy").Equals(fecha.ToString("MM/dd/yyyy")))
                {
                    actuales.Add(t);
                }
            }
            if(actuales.Count() != 0)
            {
                String print = "Se realizaron las siguientes Transacciones:\n";
                foreach(Transaccion t2 in actuales)
                {
                    print = print + t2.tipo + ": " + t2.donde + "    $" + t2.monto.ToString()+"\n";
                }
                MessageBox.Show(print);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void verTodasLasTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formTransacciones = new FormTransacciones();
            formTransacciones.Show();
            this.Hide();
        }

        private void EventoCerrarDashboard(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
