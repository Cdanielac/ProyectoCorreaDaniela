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
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.btnCargarReporte = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(553, 52);
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(100, 20);
            this.txtReporte.TabIndex = 1;
            // 
            // btnCargarReporte
            // 
            this.btnCargarReporte.Location = new System.Drawing.Point(675, 51);
            this.btnCargarReporte.Name = "btnCargarReporte";
            this.btnCargarReporte.Size = new System.Drawing.Size(75, 23);
            this.btnCargarReporte.TabIndex = 2;
            this.btnCargarReporte.Text = "Cargar Reporte";
            this.btnCargarReporte.UseVisualStyleBackColor = true;
            this.btnCargarReporte.Click += new System.EventHandler(this.btnCargarReporte_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Administrador.Reportes.RProductoPorCategoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1219, 462);
            this.reportViewer1.TabIndex = 3;
            // 
            // FReporteGeneralVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCargarReporte);
            this.Controls.Add(this.txtReporte);
            this.Name = "FReporteGeneralVentas";
            this.Text = "Reporte General Ventas";
            this.Load += new System.EventHandler(this.FReporteGeneralVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button btnCargarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}