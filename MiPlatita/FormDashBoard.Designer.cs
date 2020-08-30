namespace MiPlatita
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.TituloForm = new System.Windows.Forms.Label();
            this.botonAnadirGatos = new System.Windows.Forms.Button();
            this.botonAñadirIngresos = new System.Windows.Forms.Button();
            this.BoxUltimasTransacciones = new System.Windows.Forms.GroupBox();
            this.gridViewUltimasTransacciones = new System.Windows.Forms.DataGridView();
            this.BoxCalendario = new System.Windows.Forms.GroupBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasTransaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoxUltimasTransacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUltimasTransacciones)).BeginInit();
            this.BoxCalendario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloForm
            // 
            this.TituloForm.AutoSize = true;
            this.TituloForm.Font = new System.Drawing.Font("Maiandra GD", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.TituloForm.Location = new System.Drawing.Point(36, 37);
            this.TituloForm.Name = "TituloForm";
            this.TituloForm.Size = new System.Drawing.Size(195, 72);
            this.TituloForm.TabIndex = 1;
            this.TituloForm.Text = "Hola, ";
            this.TituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonAnadirGatos
            // 
            this.botonAnadirGatos.BackColor = System.Drawing.Color.LightCoral;
            this.botonAnadirGatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAnadirGatos.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.botonAnadirGatos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAnadirGatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.botonAnadirGatos.Location = new System.Drawing.Point(34, 98);
            this.botonAnadirGatos.Name = "botonAnadirGatos";
            this.botonAnadirGatos.Size = new System.Drawing.Size(179, 47);
            this.botonAnadirGatos.TabIndex = 3;
            this.botonAnadirGatos.Text = "Añadir Gastos";
            this.botonAnadirGatos.UseVisualStyleBackColor = false;
            this.botonAnadirGatos.Click += new System.EventHandler(this.botonAnadirGatos_Click);
            // 
            // botonAñadirIngresos
            // 
            this.botonAñadirIngresos.BackColor = System.Drawing.Color.LightCoral;
            this.botonAñadirIngresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAñadirIngresos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAñadirIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.botonAñadirIngresos.Location = new System.Drawing.Point(255, 98);
            this.botonAñadirIngresos.Name = "botonAñadirIngresos";
            this.botonAñadirIngresos.Size = new System.Drawing.Size(177, 47);
            this.botonAñadirIngresos.TabIndex = 4;
            this.botonAñadirIngresos.Text = "Añadir Ingresos";
            this.botonAñadirIngresos.UseVisualStyleBackColor = false;
            this.botonAñadirIngresos.Click += new System.EventHandler(this.botonAñadirIngresos_Click);
            // 
            // BoxUltimasTransacciones
            // 
            this.BoxUltimasTransacciones.Controls.Add(this.gridViewUltimasTransacciones);
            this.BoxUltimasTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUltimasTransacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BoxUltimasTransacciones.Location = new System.Drawing.Point(34, 155);
            this.BoxUltimasTransacciones.Name = "BoxUltimasTransacciones";
            this.BoxUltimasTransacciones.Size = new System.Drawing.Size(539, 306);
            this.BoxUltimasTransacciones.TabIndex = 5;
            this.BoxUltimasTransacciones.TabStop = false;
            this.BoxUltimasTransacciones.Text = "Últimas Transacciones";
            // 
            // gridViewUltimasTransacciones
            // 
            this.gridViewUltimasTransacciones.AllowUserToAddRows = false;
            this.gridViewUltimasTransacciones.AllowUserToDeleteRows = false;
            this.gridViewUltimasTransacciones.AllowUserToResizeColumns = false;
            this.gridViewUltimasTransacciones.AllowUserToResizeRows = false;
            this.gridViewUltimasTransacciones.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.gridViewUltimasTransacciones.ColumnHeadersHeight = 34;
            this.gridViewUltimasTransacciones.Enabled = false;
            this.gridViewUltimasTransacciones.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridViewUltimasTransacciones.Location = new System.Drawing.Point(6, 37);
            this.gridViewUltimasTransacciones.MultiSelect = false;
            this.gridViewUltimasTransacciones.Name = "gridViewUltimasTransacciones";
            this.gridViewUltimasTransacciones.RowHeadersVisible = false;
            this.gridViewUltimasTransacciones.RowHeadersWidth = 62;
            this.gridViewUltimasTransacciones.RowTemplate.Height = 45;
            this.gridViewUltimasTransacciones.RowTemplate.ReadOnly = true;
            this.gridViewUltimasTransacciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewUltimasTransacciones.ShowCellErrors = false;
            this.gridViewUltimasTransacciones.ShowCellToolTips = false;
            this.gridViewUltimasTransacciones.ShowEditingIcon = false;
            this.gridViewUltimasTransacciones.ShowRowErrors = false;
            this.gridViewUltimasTransacciones.Size = new System.Drawing.Size(523, 261);
            this.gridViewUltimasTransacciones.TabIndex = 0;
            // 
            // BoxCalendario
            // 
            this.BoxCalendario.Controls.Add(this.calendario);
            this.BoxCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCalendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BoxCalendario.Location = new System.Drawing.Point(608, 72);
            this.BoxCalendario.Name = "BoxCalendario";
            this.BoxCalendario.Size = new System.Drawing.Size(271, 205);
            this.BoxCalendario.TabIndex = 6;
            this.BoxCalendario.TabStop = false;
            this.BoxCalendario.Text = "Calendario";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(12, 32);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 0;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSelectedClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.groupBox1.Location = new System.Drawing.Point(608, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Último Mes";
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(12, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Size = new System.Drawing.Size(248, 149);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Ultimo Mes";
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
            this.menuStrip1.Size = new System.Drawing.Size(891, 33);
            this.menuStrip1.TabIndex = 8;
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
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirGastoToolStripMenuItem,
            this.añadirIngresoToolStripMenuItem,
            this.verTodasLasTransaccionesToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticasToolStripMenuItem,
            this.calendarioToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(53, 32);
            this.verToolStripMenuItem.Text = "Ver";
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
            this.añadirIngresoToolStripMenuItem.Click += new System.EventHandler(this.botonAñadirIngresos_Click);
            // 
            // verTodasLasTransaccionesToolStripMenuItem
            // 
            this.verTodasLasTransaccionesToolStripMenuItem.Name = "verTodasLasTransaccionesToolStripMenuItem";
            this.verTodasLasTransaccionesToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.verTodasLasTransaccionesToolStripMenuItem.Text = "Ver todas las Transacciones";
            this.verTodasLasTransaccionesToolStripMenuItem.Click += new System.EventHandler(this.verTodasLasTransaccionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(891, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoxCalendario);
            this.Controls.Add(this.BoxUltimasTransacciones);
            this.Controls.Add(this.botonAñadirIngresos);
            this.Controls.Add(this.botonAnadirGatos);
            this.Controls.Add(this.TituloForm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDashboard";
            this.Text = "Mi Platita - Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventoCerrarDashboard);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.BoxUltimasTransacciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUltimasTransacciones)).EndInit();
            this.BoxCalendario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloForm;
        private System.Windows.Forms.Button botonAnadirGatos;
        private System.Windows.Forms.Button botonAñadirIngresos;
        private System.Windows.Forms.GroupBox BoxUltimasTransacciones;
        private System.Windows.Forms.DataGridView gridViewUltimasTransacciones;
        private System.Windows.Forms.GroupBox BoxCalendario;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasLasTransaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
    }
}