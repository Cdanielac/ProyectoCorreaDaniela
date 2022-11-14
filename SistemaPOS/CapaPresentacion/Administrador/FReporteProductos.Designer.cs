namespace CapaPresentacion.Administrador
{
    partial class FReporteProductos
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dSProductos = new CapaPresentacion.DSProductos();
            this.productoCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoCategoriaTableAdapter = new CapaPresentacion.DSProductosTableAdapters.ProductoCategoriaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VentasCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasCategoriaTableAdapter = new CapaPresentacion.DSProductosTableAdapters.VentasCategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(63, 77);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(92, 22);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoría";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(161, 77);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 29);
            this.cbCategoria.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "CARGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dSProductos
            // 
            this.dSProductos.DataSetName = "DSProductos";
            this.dSProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoCategoriaBindingSource
            // 
            this.productoCategoriaBindingSource.DataMember = "ProductoCategoria";
            this.productoCategoriaBindingSource.DataSource = this.dSProductos;
            // 
            // productoCategoriaTableAdapter
            // 
            this.productoCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Administrador.Reportes.RProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(45, 134);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1212, 424);
            this.reportViewer1.TabIndex = 5;
            // 
            // VentasCBindingSource
            // 
            this.VentasCBindingSource.DataMember = "VentasCategoria";
            this.VentasCBindingSource.DataSource = this.dSProductos;
            // 
            // ventasCategoriaTableAdapter
            // 
            this.ventasCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Name = "FReporteProductos";
            this.Text = "FReporteProductos";
            this.Load += new System.EventHandler(this.FReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource productoCategoriaBindingSource;
        private DSProductos dSProductos;
        private DSProductosTableAdapters.ProductoCategoriaTableAdapter productoCategoriaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VentasCBindingSource;
        private DSProductosTableAdapters.VentasCategoriaTableAdapter ventasCategoriaTableAdapter;
    }
}