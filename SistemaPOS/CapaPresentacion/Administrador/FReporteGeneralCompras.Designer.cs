namespace CapaPresentacion.Administrador
{
    partial class FReporteGeneralCompras
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbContenedor3 = new System.Windows.Forms.GroupBox();
            this.chGanancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbContenedor2 = new System.Windows.Forms.GroupBox();
            this.chComprasUsuario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbContenedor1 = new System.Windows.Forms.GroupBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.chComprasCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbContenedor3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGanancias)).BeginInit();
            this.gbContenedor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chComprasUsuario)).BeginInit();
            this.gbContenedor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chComprasCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenedor3
            // 
            this.gbContenedor3.BackColor = System.Drawing.Color.Thistle;
            this.gbContenedor3.Controls.Add(this.chGanancias);
            this.gbContenedor3.Location = new System.Drawing.Point(654, 288);
            this.gbContenedor3.Name = "gbContenedor3";
            this.gbContenedor3.Size = new System.Drawing.Size(570, 271);
            this.gbContenedor3.TabIndex = 5;
            this.gbContenedor3.TabStop = false;
            this.gbContenedor3.Text = " Ganancias";
            // 
            // chGanancias
            // 
            chartArea4.Name = "ChartArea1";
            this.chGanancias.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chGanancias.Legends.Add(legend4);
            this.chGanancias.Location = new System.Drawing.Point(34, 41);
            this.chGanancias.Name = "chGanancias";
            this.chGanancias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chGanancias.Series.Add(series4);
            this.chGanancias.Size = new System.Drawing.Size(510, 207);
            this.chGanancias.TabIndex = 2;
            this.chGanancias.Text = "Ventas Por Categoría";
            // 
            // gbContenedor2
            // 
            this.gbContenedor2.BackColor = System.Drawing.Color.Thistle;
            this.gbContenedor2.Controls.Add(this.chComprasUsuario);
            this.gbContenedor2.Location = new System.Drawing.Point(51, 288);
            this.gbContenedor2.Name = "gbContenedor2";
            this.gbContenedor2.Size = new System.Drawing.Size(569, 271);
            this.gbContenedor2.TabIndex = 4;
            this.gbContenedor2.TabStop = false;
            this.gbContenedor2.Text = "Compras Por Usuario";
            // 
            // chComprasUsuario
            // 
            chartArea5.Name = "ChartArea1";
            this.chComprasUsuario.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chComprasUsuario.Legends.Add(legend5);
            this.chComprasUsuario.Location = new System.Drawing.Point(34, 41);
            this.chComprasUsuario.Name = "chComprasUsuario";
            this.chComprasUsuario.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chComprasUsuario.Series.Add(series5);
            this.chComprasUsuario.Size = new System.Drawing.Size(510, 207);
            this.chComprasUsuario.TabIndex = 1;
            this.chComprasUsuario.Text = "Ventas Por Categoría";
            // 
            // gbContenedor1
            // 
            this.gbContenedor1.BackColor = System.Drawing.Color.Thistle;
            this.gbContenedor1.Controls.Add(this.iconButton2);
            this.gbContenedor1.Controls.Add(this.chComprasCategoria);
            this.gbContenedor1.Location = new System.Drawing.Point(40, 21);
            this.gbContenedor1.Name = "gbContenedor1";
            this.gbContenedor1.Size = new System.Drawing.Size(1199, 244);
            this.gbContenedor1.TabIndex = 3;
            this.gbContenedor1.TabStop = false;
            this.gbContenedor1.Text = "Compras por Categoría";
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
            // chComprasCategoria
            // 
            chartArea6.Name = "ChartArea1";
            this.chComprasCategoria.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chComprasCategoria.Legends.Add(legend6);
            this.chComprasCategoria.Location = new System.Drawing.Point(206, 23);
            this.chComprasCategoria.Name = "chComprasCategoria";
            this.chComprasCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chComprasCategoria.Series.Add(series6);
            this.chComprasCategoria.Size = new System.Drawing.Size(799, 207);
            this.chComprasCategoria.TabIndex = 0;
            this.chComprasCategoria.Text = "Ventas Por Categoría";
            // 
            // FReporteGeneralCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.gbContenedor3);
            this.Controls.Add(this.gbContenedor2);
            this.Controls.Add(this.gbContenedor1);
            this.Name = "FReporteGeneralCompras";
            this.Text = "Reporte General Compras";
            this.Load += new System.EventHandler(this.FReporteGeneralCompras_Load);
            this.gbContenedor3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chGanancias)).EndInit();
            this.gbContenedor2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chComprasUsuario)).EndInit();
            this.gbContenedor1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chComprasCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGanancias;
        private System.Windows.Forms.GroupBox gbContenedor2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chComprasUsuario;
        private System.Windows.Forms.GroupBox gbContenedor1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chComprasCategoria;
    }
}