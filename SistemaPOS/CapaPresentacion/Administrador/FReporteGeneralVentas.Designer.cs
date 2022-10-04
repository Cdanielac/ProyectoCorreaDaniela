namespace CapaPresentacion.Administrador
{
    partial class FReporteGeneralVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbContenedor1 = new System.Windows.Forms.GroupBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.chVentasCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbContenedor2 = new System.Windows.Forms.GroupBox();
            this.chVentasUsuario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbContenedor3 = new System.Windows.Forms.GroupBox();
            this.chGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbContenedor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chVentasCategoria)).BeginInit();
            this.gbContenedor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chVentasUsuario)).BeginInit();
            this.gbContenedor3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenedor1
            // 
            this.gbContenedor1.Controls.Add(this.iconButton2);
            this.gbContenedor1.Controls.Add(this.chVentasCategoria);
            this.gbContenedor1.Location = new System.Drawing.Point(45, 12);
            this.gbContenedor1.Name = "gbContenedor1";
            this.gbContenedor1.Size = new System.Drawing.Size(1199, 244);
            this.gbContenedor1.TabIndex = 0;
            this.gbContenedor1.TabStop = false;
            this.gbContenedor1.Text = "Ventas por Categoría";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(1056, 30);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(109, 27);
            this.iconButton2.TabIndex = 31;
            this.iconButton2.Text = "DESCARGAR";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // chVentasCategoria
            // 
            chartArea1.Name = "ChartArea1";
            this.chVentasCategoria.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chVentasCategoria.Legends.Add(legend1);
            this.chVentasCategoria.Location = new System.Drawing.Point(206, 23);
            this.chVentasCategoria.Name = "chVentasCategoria";
            this.chVentasCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chVentasCategoria.Series.Add(series1);
            this.chVentasCategoria.Size = new System.Drawing.Size(799, 207);
            this.chVentasCategoria.TabIndex = 0;
            this.chVentasCategoria.Text = "Ventas Por Categoría";
            // 
            // gbContenedor2
            // 
            this.gbContenedor2.Controls.Add(this.chVentasUsuario);
            this.gbContenedor2.Location = new System.Drawing.Point(56, 279);
            this.gbContenedor2.Name = "gbContenedor2";
            this.gbContenedor2.Size = new System.Drawing.Size(569, 271);
            this.gbContenedor2.TabIndex = 1;
            this.gbContenedor2.TabStop = false;
            this.gbContenedor2.Text = "Ventas Por Usuario";
            // 
            // chVentasUsuario
            // 
            chartArea2.Name = "ChartArea1";
            this.chVentasUsuario.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chVentasUsuario.Legends.Add(legend2);
            this.chVentasUsuario.Location = new System.Drawing.Point(34, 41);
            this.chVentasUsuario.Name = "chVentasUsuario";
            this.chVentasUsuario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chVentasUsuario.Series.Add(series2);
            this.chVentasUsuario.Size = new System.Drawing.Size(510, 207);
            this.chVentasUsuario.TabIndex = 1;
            this.chVentasUsuario.Text = "Ventas Por Categoría";
            // 
            // gbContenedor3
            // 
            this.gbContenedor3.Controls.Add(this.chGanancias);
            this.gbContenedor3.Location = new System.Drawing.Point(659, 279);
            this.gbContenedor3.Name = "gbContenedor3";
            this.gbContenedor3.Size = new System.Drawing.Size(570, 271);
            this.gbContenedor3.TabIndex = 2;
            this.gbContenedor3.TabStop = false;
            this.gbContenedor3.Text = " Ganancias";
            // 
            // chGanancias
            // 
            chartArea3.Name = "ChartArea1";
            this.chGanancias.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chGanancias.Legends.Add(legend3);
            this.chGanancias.Location = new System.Drawing.Point(34, 41);
            this.chGanancias.Name = "chGanancias";
            this.chGanancias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chGanancias.Series.Add(series3);
            this.chGanancias.Size = new System.Drawing.Size(510, 207);
            this.chGanancias.TabIndex = 2;
            this.chGanancias.Text = "Ventas Por Categoría";
            // 
            // FReporteGeneralVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.gbContenedor3);
            this.Controls.Add(this.gbContenedor2);
            this.Controls.Add(this.gbContenedor1);
            this.Name = "FReporteGeneralVentas";
            this.Text = "Reporte General Ventas";
            this.Load += new System.EventHandler(this.FReporteGeneralVentas_Load);
            this.gbContenedor1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chVentasCategoria)).EndInit();
            this.gbContenedor2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chVentasUsuario)).EndInit();
            this.gbContenedor3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chGanancias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor1;
        private System.Windows.Forms.GroupBox gbContenedor2;
        private System.Windows.Forms.GroupBox gbContenedor3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chVentasCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chVentasUsuario;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGanancias;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}