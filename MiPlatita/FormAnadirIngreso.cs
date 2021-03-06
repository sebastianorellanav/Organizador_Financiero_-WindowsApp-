﻿using MiPlatita.BackEnd;
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
    public partial class FormAnadirIngreso : Form
    {
        public FormAnadirIngreso()
        {
            InitializeComponent();
        }

        private void botonAñadir_Click(object sender, EventArgs e)
        {
            Transaccion nueva_tr = new Transaccion();
            nueva_tr.donde = inputDonde.Text;
            nueva_tr.cuando = inputCuando.Value;
            try
            {
                nueva_tr.monto = Int32.Parse(inputMonto.Text);
                nueva_tr.tipo = "ingreso";
                nueva_tr.GuardarTransaccion(nueva_tr);
                Form formDashboard = new FormDashboard();
                formDashboard.Show();
                this.Hide();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor ingrese un monto válido.");
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Form formDashboard = new FormDashboard();
            formDashboard.Show();
            this.Hide();
        }

        private void eventoCerrarForm(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
