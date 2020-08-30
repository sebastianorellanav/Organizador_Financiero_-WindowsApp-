namespace MiPlatita
{
    partial class FormAnadirGasto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonAñadir = new System.Windows.Forms.Button();
            this.inputDonde = new System.Windows.Forms.TextBox();
            this.subtitutloFormBienvenida1 = new System.Windows.Forms.Label();
            this.TituloFormBienvenida = new System.Windows.Forms.Label();
            this.MontoGasto = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.inputCuando = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.inputMonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonAñadir
            // 
            this.botonAñadir.BackColor = System.Drawing.Color.LightCoral;
            this.botonAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.botonAñadir.Location = new System.Drawing.Point(154, 518);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(159, 57);
            this.botonAñadir.TabIndex = 8;
            this.botonAñadir.Text = "Añadir";
            this.botonAñadir.UseVisualStyleBackColor = false;
            this.botonAñadir.Click += new System.EventHandler(this.botonAñadir_Click);
            // 
            // inputDonde
            // 
            this.inputDonde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputDonde.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputDonde.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDonde.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.inputDonde.Location = new System.Drawing.Point(140, 238);
            this.inputDonde.Name = "inputDonde";
            this.inputDonde.Size = new System.Drawing.Size(390, 26);
            this.inputDonde.TabIndex = 7;
            this.inputDonde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subtitutloFormBienvenida1
            // 
            this.subtitutloFormBienvenida1.AutoSize = true;
            this.subtitutloFormBienvenida1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitutloFormBienvenida1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.subtitutloFormBienvenida1.Location = new System.Drawing.Point(119, 179);
            this.subtitutloFormBienvenida1.Name = "subtitutloFormBienvenida1";
            this.subtitutloFormBienvenida1.Size = new System.Drawing.Size(426, 39);
            this.subtitutloFormBienvenida1.TabIndex = 6;
            this.subtitutloFormBienvenida1.Text = "¿Donde se realizo el gasto?";
            // 
            // TituloFormBienvenida
            // 
            this.TituloFormBienvenida.AutoSize = true;
            this.TituloFormBienvenida.Font = new System.Drawing.Font("Maiandra GD", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFormBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.TituloFormBienvenida.Location = new System.Drawing.Point(77, 53);
            this.TituloFormBienvenida.Name = "TituloFormBienvenida";
            this.TituloFormBienvenida.Size = new System.Drawing.Size(497, 96);
            this.TituloFormBienvenida.TabIndex = 5;
            this.TituloFormBienvenida.Text = "Añadir Gasto";
            this.TituloFormBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MontoGasto
            // 
            this.MontoGasto.AutoSize = true;
            this.MontoGasto.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.MontoGasto.Location = new System.Drawing.Point(174, 287);
            this.MontoGasto.Name = "MontoGasto";
            this.MontoGasto.Size = new System.Drawing.Size(324, 39);
            this.MontoGasto.TabIndex = 9;
            this.MontoGasto.Text = "¿Cuándo se realizó?";
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.Color.DimGray;
            this.botonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.botonCancelar.Location = new System.Drawing.Point(350, 518);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(159, 57);
            this.botonCancelar.TabIndex = 11;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // inputCuando
            // 
            this.inputCuando.Location = new System.Drawing.Point(140, 342);
            this.inputCuando.Name = "inputCuando";
            this.inputCuando.Size = new System.Drawing.Size(390, 26);
            this.inputCuando.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.label1.Location = new System.Drawing.Point(174, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "¿Cuál fue el Monto?";
            // 
            // inputMonto
            // 
            this.inputMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputMonto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.inputMonto.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMonto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.inputMonto.Location = new System.Drawing.Point(136, 445);
            this.inputMonto.Name = "inputMonto";
            this.inputMonto.Size = new System.Drawing.Size(390, 26);
            this.inputMonto.TabIndex = 18;
            this.inputMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAnadirGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(662, 627);
            this.Controls.Add(this.inputMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputCuando);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.MontoGasto);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.inputDonde);
            this.Controls.Add(this.subtitutloFormBienvenida1);
            this.Controls.Add(this.TituloFormBienvenida);
            this.Name = "FormAnadirGasto";
            this.Text = "FormAñadirGasto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.eventoCerrarForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAñadir;
        private System.Windows.Forms.TextBox inputDonde;
        private System.Windows.Forms.Label subtitutloFormBienvenida1;
        private System.Windows.Forms.Label TituloFormBienvenida;
        private System.Windows.Forms.Label MontoGasto;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.DateTimePicker inputCuando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputMonto;
    }
}