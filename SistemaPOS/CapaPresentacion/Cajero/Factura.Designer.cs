namespace CapaPresentacion.Cajero
{
    partial class Factura
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_POSDataSet = new CapaPresentacion.DB_POSDataSet();
            this.facturaTableAdapter = new CapaPresentacion.DB_POSDataSetTableAdapters.FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSFactura";
            reportDataSource1.Value = this.facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Administrador.Reportes.Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(38, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(734, 592);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.dBPOSDataSetBindingSource;
            // 
            // dBPOSDataSetBindingSource
            // 
            this.dBPOSDataSetBindingSource.DataSource = this.dB_POSDataSet;
            this.dBPOSDataSetBindingSource.Position = 0;
            // 
            // dB_POSDataSet
            // 
            this.dB_POSDataSet.DataSetName = "DB_POSDataSet";
            this.dB_POSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.BindingSource dBPOSDataSetBindingSource;
        private DB_POSDataSet dB_POSDataSet;
        private DB_POSDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
    }
}