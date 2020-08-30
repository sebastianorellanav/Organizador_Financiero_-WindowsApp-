using MiPlatita.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPlatita
{
    public partial class FormTransacciones : Form
    {
        private List<Transaccion> transacciones;
        public FormTransacciones()
        {
            InitializeComponent();
            transacciones = new Transaccion().obtenerTodasTransacciones();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a
            // column count.
            gridViewTransacciones.ScrollBars = ScrollBars.None;
            gridViewTransacciones.ColumnCount = 5;
            gridViewTransacciones.ColumnHeadersVisible = true;
            gridViewTransacciones.Size = new Size(700, 400);

            //AdjustDataGridViewSizing();

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellsStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.DarkBlue;
            columnHeaderStyle.Font =
                new Font("Arial", 12, FontStyle.Bold);
            gridViewTransacciones.ColumnHeadersDefaultCellStyle =
                columnHeaderStyle;
            cellsStyle.Font = new Font("Arial", 11);
            gridViewTransacciones.DefaultCellStyle = cellsStyle;
            gridViewTransacciones.Dock = DockStyle.Fill;
            ;

            // Set the column header names.
            gridViewTransacciones.Columns[0].Name = "#";
            gridViewTransacciones.Columns[0].Width = 50;
            gridViewTransacciones.Columns[1].Name = "Nombre";
            gridViewTransacciones.Columns[1].Width = 200;
            gridViewTransacciones.Columns[2].Name = "Fecha";
            gridViewTransacciones.Columns[2].Width = 150;
            gridViewTransacciones.Columns[3].Name = "Abono";
            gridViewTransacciones.Columns[3].Width = 150;
            gridViewTransacciones.Columns[4].Name = "Deposito";
            gridViewTransacciones.Columns[4].Width = 150;
            int i = 0;
            // Populate the rows.
            if (transacciones != null)
            {
                foreach(Transaccion t in transacciones)
                {
                    string[] row1;
                    if (t.tipo.Equals("ingreso"))
                    {
                        row1 = new string[]{t.id.ToString(),
                                            t.donde, t.cuando.ToString("dd-MM-yyyy"),
                                            "$"+t.monto.ToString(), "$0" };
                    }
                    else
                    {
                        row1 = new string[]{t.id.ToString(),
                                            t.donde, t.cuando.ToString("dd/MM/yyyy"),
                                            "$0","$"+t.monto.ToString()};
                    }

                    gridViewTransacciones.Rows.Add(row1);
                    gridViewTransacciones.Rows[i].Frozen = false;
                }
            }

            gridViewTransacciones.ScrollBars = ScrollBars.Vertical;
            //gridViewTransacciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridViewTransacciones.Controls[1].Enabled = true;
        }

        private void bontonVolver_Click(object sender, EventArgs e)
        {
            Form formDashBoard = new FormDashboard();
            formDashBoard.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void botonAnadirGatos_Click(object sender, EventArgs e)
        {
            Form formAnadirGasto = new FormAnadirGasto();
            formAnadirGasto.Show();
            this.Hide();
        }

        private void añadirIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAnadirIngreso = new FormAnadirIngreso();
            formAnadirIngreso.Show();
            this.Hide();
        }

        private void eventoCerrarForm(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
