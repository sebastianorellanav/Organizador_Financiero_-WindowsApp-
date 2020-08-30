namespace MiPlatita
{
    partial class FormBienvenida
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloFormBienvenida = new System.Windows.Forms.Label();
            this.subtitutloFormBienvenida1 = new System.Windows.Forms.Label();
            this.subtituloFormBienvenida2 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.botonFormBienvenida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloFormBienvenida
            // 
            this.TituloFormBienvenida.AutoSize = true;
            this.TituloFormBienvenida.Font = new System.Drawing.Font("Maiandra GD", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFormBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.TituloFormBienvenida.Location = new System.Drawing.Point(127, 126);
            this.TituloFormBienvenida.Name = "TituloFormBienvenida";
            this.TituloFormBienvenida.Size = new System.Drawing.Size(471, 96);
            this.TituloFormBienvenida.TabIndex = 0;
            this.TituloFormBienvenida.Text = "MI PLATITA";
            this.TituloFormBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitutloFormBienvenida1
            // 
            this.subtitutloFormBienvenida1.AutoSize = true;
            this.subtitutloFormBienvenida1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitutloFormBienvenida1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.subtitutloFormBienvenida1.Location = new System.Drawing.Point(262, 261);
            this.subtitutloFormBienvenida1.Name = "subtitutloFormBienvenida1";
            this.subtitutloFormBienvenida1.Size = new System.Drawing.Size(199, 39);
            this.subtitutloFormBienvenida1.TabIndex = 1;
            this.subtitutloFormBienvenida1.Text = "Bienvenide, ";
            // 
            // subtituloFormBienvenida2
            // 
            this.subtituloFormBienvenida2.AutoSize = true;
            this.subtituloFormBienvenida2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtituloFormBienvenida2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.subtituloFormBienvenida2.Location = new System.Drawing.Point(93, 300);
            this.subtituloFormBienvenida2.Name = "subtituloFormBienvenida2";
            this.subtituloFormBienvenida2.Size = new System.Drawing.Size(518, 39);
            this.subtituloFormBienvenida2.TabIndex = 2;
            this.subtituloFormBienvenida2.Text = "para comenzar ingresa tu nombre:";
            // 
            // boxName
            // 
            this.boxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.boxName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.boxName.Location = new System.Drawing.Point(222, 360);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(254, 26);
            this.boxName.TabIndex = 3;
            this.boxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botonFormBienvenida
            // 
            this.botonFormBienvenida.BackColor = System.Drawing.Color.LightCoral;
            this.botonFormBienvenida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonFormBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonFormBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.botonFormBienvenida.Location = new System.Drawing.Point(271, 409);
            this.botonFormBienvenida.Name = "botonFormBienvenida";
            this.botonFormBienvenida.Size = new System.Drawing.Size(159, 57);
            this.botonFormBienvenida.TabIndex = 4;
            this.botonFormBienvenida.Text = "Ingresar";
            this.botonFormBienvenida.UseVisualStyleBackColor = false;
            this.botonFormBienvenida.Click += new System.EventHandler(this.eventoIngresar);
            // 
            // FormBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(731, 677);
            this.Controls.Add(this.botonFormBienvenida);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.subtituloFormBienvenida2);
            this.Controls.Add(this.subtitutloFormBienvenida1);
            this.Controls.Add(this.TituloFormBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBienvenida";
            this.Text = "Mi Platita";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.eventoCerrarForm);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloFormBienvenida;
        private System.Windows.Forms.Label subtitutloFormBienvenida1;
        private System.Windows.Forms.Label subtituloFormBienvenida2;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Button botonFormBienvenida;
    }
}

