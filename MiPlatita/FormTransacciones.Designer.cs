namespace MiPlatita
{
    partial class FormTransacciones
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bontonVolver = new System.Windows.Forms.Button();
            this.BoxUltimasTransacciones = new System.Windows.Forms.GroupBox();
            this.gridViewTransacciones = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.BoxUltimasTransacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirGastoToolStripMenuItem,
            this.añadirIngresoToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // añadirGastoToolStripMenuItem
            // 
            this.añadirGastoToolStripMenuItem.Name = "añadirGastoToolStripMenuItem";
            this.añadirGastoToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.añadirGastoToolStripMenuItem.Text = "Añadir Gasto";
            this.añadirGastoToolStripMenuItem.Click += new System.EventHandler(this.botonAnadirGatos_Click);
            // 
            // añadirIngresoToolStripMenuItem
            // 
            this.añadirIngresoToolStripMenuItem.Name = "añadirIngresoToolStripMenuItem";
            this.añadirIngresoToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.añadirIngresoToolStripMenuItem.Text = "Añadir Ingreso";
            this.añadirIngresoToolStripMenuItem.Click += new System.EventHandler(this.añadirIngresoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticasToolStripMenuItem,
            this.calendarioToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // bontonVolver
            // 
            this.bontonVolver.BackColor = System.Drawing.Color.LightCoral;
            this.bontonVolver.Font = new System.Drawing.Font("Arial", 9F);
            this.bontonVolver.Location = new System.Drawing.Point(912, 39);
            this.bontonVolver.Name = "bontonVolver";
            this.bontonVolver.Size = new System.Drawing.Size(93, 36);
            this.bontonVolver.TabIndex = 10;
            this.bontonVolver.Text = "Volver";
            this.bontonVolver.UseVisualStyleBackColor = false;
            this.bontonVolver.Click += new System.EventHandler(this.bontonVolver_Click);
            // 
            // BoxUltimasTransacciones
            // 
            this.BoxUltimasTransacciones.Controls.Add(this.gridViewTransacciones);
            this.BoxUltimasTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUltimasTransacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BoxUltimasTransacciones.Location = new System.Drawing.Point(12, 62);
            this.BoxUltimasTransacciones.Name = "BoxUltimasTransacciones";
            this.BoxUltimasTransacciones.Size = new System.Drawing.Size(993, 479);
            this.BoxUltimasTransacciones.TabIndex = 6;
            this.BoxUltimasTransacciones.TabStop = false;
            this.BoxUltimasTransacciones.Text = "Todas las Transacciones";
            // 
            // gridViewTransacciones
            // 
            this.gridViewTransacciones.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.gridViewTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTransacciones.Location = new System.Drawing.Point(57, 86);
            this.gridViewTransacciones.Name = "gridViewTransacciones";
            this.gridViewTransacciones.ReadOnly = true;
            this.gridViewTransacciones.RowHeadersVisible = false;
            this.gridViewTransacciones.RowHeadersWidth = 62;
            this.gridViewTransacciones.RowTemplate.Height = 28;
            this.gridViewTransacciones.Size = new System.Drawing.Size(240, 150);
            this.gridViewTransacciones.TabIndex = 0;
            // 
            // FormTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1028, 559);
            this.Controls.Add(this.bontonVolver);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BoxUltimasTransacciones);
            this.Name = "FormTransacciones";
            this.Text = "FormTransacciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.eventoCerrarForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BoxUltimasTransacciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.Button bontonVolver;
        private System.Windows.Forms.GroupBox BoxUltimasTransacciones;
        private System.Windows.Forms.DataGridView gridViewTransacciones;
    }
}