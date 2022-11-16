namespace CapaPresentacion.Administrador
{
    partial class FRepVentaRV
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventaCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVentas = new CapaPresentacion.DSVentas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventaCajaTableAdapter = new CapaPresentacion.DSVentasTableAdapters.VentaCajaTableAdapter();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaTableAdapter = new CapaPresentacion.DSVentasTableAdapters.DetalleVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventaCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ventaCajaBindingSource
            // 
            this.ventaCajaBindingSource.DataMember = "VentaCaja";
            this.ventaCajaBindingSource.DataSource = this.dSVentas;
            // 
            // dSVentas
            // 
            this.dSVentas.DataSetName = "DSVentas";
            this.dSVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ventaCajaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Administrador.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventaCajaTableAdapter
            // 
            this.ventaCajaTableAdapter.ClearBeforeFill = true;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "DetalleVenta";
            this.detalleVentaBindingSource.DataSource = this.dSVentas;
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // FRepVentaRV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(763, 682);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRepVentaRV";
            this.Text = "Reporte Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSVentas dSVentas;
        private System.Windows.Forms.BindingSource ventaCajaBindingSource;
        private DSVentasTableAdapters.VentaCajaTableAdapter ventaCajaTableAdapter;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private DSVentasTableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter;
    }
}