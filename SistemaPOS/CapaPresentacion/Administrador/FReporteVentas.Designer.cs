namespace CapaPresentacion.Administrador
{
    partial class FReporteVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbReporteVentas = new System.Windows.Forms.GroupBox();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblFinal = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.CNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.cbCodProducto = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReporteGeneral = new FontAwesome.Sharp.IconButton();
            this.gbReporteVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReporteVentas
            // 
            this.gbReporteVentas.Controls.Add(this.dtFechaHasta);
            this.gbReporteVentas.Controls.Add(this.iconButton1);
            this.gbReporteVentas.Controls.Add(this.lblFinal);
            this.gbReporteVentas.Controls.Add(this.dtFechaDesde);
            this.gbReporteVentas.Controls.Add(this.lblInicio);
            this.gbReporteVentas.Location = new System.Drawing.Point(38, 23);
            this.gbReporteVentas.Name = "gbReporteVentas";
            this.gbReporteVentas.Size = new System.Drawing.Size(695, 100);
            this.gbReporteVentas.TabIndex = 0;
            this.gbReporteVentas.TabStop = false;
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaHasta.Location = new System.Drawing.Point(392, 40);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(108, 20);
            this.dtFechaHasta.TabIndex = 32;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(540, 36);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(89, 27);
            this.iconButton1.TabIndex = 30;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(277, 40);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(94, 17);
            this.lblFinal.TabIndex = 31;
            this.lblFinal.Text = "Fecha hasta: ";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaDesde.Location = new System.Drawing.Point(136, 37);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(108, 20);
            this.dtFechaDesde.TabIndex = 2;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(31, 36);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(99, 17);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Fecha desde: ";
            // 
            // dgVentas
            // 
            this.dgVentas.AllowUserToAddRows = false;
            this.dgVentas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNroVenta,
            this.CCliente,
            this.CUsuario,
            this.Ctotal,
            this.CVerDetalle});
            this.dgVentas.Location = new System.Drawing.Point(39, 203);
            this.dgVentas.MultiSelect = false;
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVentas.Size = new System.Drawing.Size(541, 365);
            this.dgVentas.TabIndex = 87;
            // 
            // CNroVenta
            // 
            this.CNroVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNroVenta.HeaderText = "NRO VENTA";
            this.CNroVenta.Name = "CNroVenta";
            this.CNroVenta.ReadOnly = true;
            // 
            // CCliente
            // 
            this.CCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCliente.HeaderText = "CLIENTE";
            this.CCliente.Name = "CCliente";
            this.CCliente.ReadOnly = true;
            // 
            // CUsuario
            // 
            this.CUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUsuario.HeaderText = "USUARIO";
            this.CUsuario.Name = "CUsuario";
            this.CUsuario.ReadOnly = true;
            // 
            // Ctotal
            // 
            this.Ctotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ctotal.HeaderText = "TOTAL";
            this.Ctotal.Name = "Ctotal";
            this.Ctotal.ReadOnly = true;
            // 
            // CVerDetalle
            // 
            this.CVerDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CVerDetalle.HeaderText = "";
            this.CVerDetalle.Name = "CVerDetalle";
            this.CVerDetalle.ReadOnly = true;
            this.CVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CVerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CVerDetalle.Text = "Ver Detalle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.cbCodProducto);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Location = new System.Drawing.Point(38, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 67);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(1099, 23);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(89, 27);
            this.iconButton3.TabIndex = 33;
            this.iconButton3.Text = "Buscar";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // cbCodProducto
            // 
            this.cbCodProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodProducto.FormattingEnabled = true;
            this.cbCodProducto.Location = new System.Drawing.Point(857, 27);
            this.cbCodProducto.Name = "cbCodProducto";
            this.cbCodProducto.Size = new System.Drawing.Size(225, 21);
            this.cbCodProducto.TabIndex = 86;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(772, 27);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(79, 17);
            this.lblBuscar.TabIndex = 33;
            this.lblBuscar.Text = "Nro Venta:";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(21, 23);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(109, 27);
            this.iconButton2.TabIndex = 30;
            this.iconButton2.Text = "DESCARGAR";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // dgDetalleVenta
            // 
            this.dgDetalleVenta.AllowUserToAddRows = false;
            this.dgDetalleVenta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CNombre,
            this.CCantidad,
            this.CPrecioVenta,
            this.CSubtotal});
            this.dgDetalleVenta.Location = new System.Drawing.Point(597, 203);
            this.dgDetalleVenta.MultiSelect = false;
            this.dgDetalleVenta.Name = "dgDetalleVenta";
            this.dgDetalleVenta.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDetalleVenta.Size = new System.Drawing.Size(670, 365);
            this.dgDetalleVenta.TabIndex = 88;
            // 
            // CCodigo
            // 
            this.CCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCodigo.HeaderText = "CÓDIGO";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.HeaderText = "NOMBRE";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CCantidad
            // 
            this.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCantidad.HeaderText = "CANTIDAD";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            // 
            // CPrecioVenta
            // 
            this.CPrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPrecioVenta.HeaderText = "PRECIO VENTA";
            this.CPrecioVenta.Name = "CPrecioVenta";
            this.CPrecioVenta.ReadOnly = true;
            // 
            // CSubtotal
            // 
            this.CSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CSubtotal.HeaderText = "SUBTOTAL";
            this.CSubtotal.Name = "CSubtotal";
            this.CSubtotal.ReadOnly = true;
            // 
            // btnReporteGeneral
            // 
            this.btnReporteGeneral.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteGeneral.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnReporteGeneral.IconColor = System.Drawing.Color.Black;
            this.btnReporteGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteGeneral.IconSize = 20;
            this.btnReporteGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteGeneral.Location = new System.Drawing.Point(921, 41);
            this.btnReporteGeneral.Name = "btnReporteGeneral";
            this.btnReporteGeneral.Size = new System.Drawing.Size(189, 55);
            this.btnReporteGeneral.TabIndex = 87;
            this.btnReporteGeneral.Text = "Reporte General";
            this.btnReporteGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteGeneral.UseVisualStyleBackColor = true;
            this.btnReporteGeneral.Click += new System.EventHandler(this.btnReporteGeneral_Click);
            // 
            // FReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.btnReporteGeneral);
            this.Controls.Add(this.dgDetalleVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgVentas);
            this.Controls.Add(this.gbReporteVentas);
            this.Name = "FReporteVentas";
            this.Text = "Reporte Ventas";
            this.Load += new System.EventHandler(this.FReporteVentas_Load);
            this.gbReporteVentas.ResumeLayout(false);
            this.gbReporteVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReporteVentas;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBuscar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ComboBox cbCodProducto;
        private System.Windows.Forms.DataGridView dgDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctotal;
        private System.Windows.Forms.DataGridViewButtonColumn CVerDetalle;
        private FontAwesome.Sharp.IconButton btnReporteGeneral;
    }
}