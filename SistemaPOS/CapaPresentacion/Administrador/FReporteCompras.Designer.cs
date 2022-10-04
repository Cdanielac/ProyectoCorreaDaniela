namespace CapaPresentacion.Administrador
{
    partial class FReporteCompras
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
            this.dgDetalleCompra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.cbNroCompra = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dgCompras = new System.Windows.Forms.DataGridView();
            this.gbReporteVentas = new System.Windows.Forms.GroupBox();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblFinal = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnReporteGeneral = new FontAwesome.Sharp.IconButton();
            this.verDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).BeginInit();
            this.gbReporteVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDetalleCompra
            // 
            this.dgDetalleCompra.AllowUserToAddRows = false;
            this.dgDetalleCompra.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleCompra.Location = new System.Drawing.Point(584, 189);
            this.dgDetalleCompra.MultiSelect = false;
            this.dgDetalleCompra.Name = "dgDetalleCompra";
            this.dgDetalleCompra.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalleCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetalleCompra.Size = new System.Drawing.Size(670, 378);
            this.dgDetalleCompra.TabIndex = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.cbNroCompra);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Location = new System.Drawing.Point(25, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 67);
            this.groupBox1.TabIndex = 90;
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
            // cbNroCompra
            // 
            this.cbNroCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNroCompra.FormattingEnabled = true;
            this.cbNroCompra.Location = new System.Drawing.Point(857, 27);
            this.cbNroCompra.Name = "cbNroCompra";
            this.cbNroCompra.Size = new System.Drawing.Size(225, 21);
            this.cbNroCompra.TabIndex = 86;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(757, 29);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(94, 17);
            this.lblBuscar.TabIndex = 33;
            this.lblBuscar.Text = "Nro Compra:";
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
            // dgCompras
            // 
            this.dgCompras.AllowUserToAddRows = false;
            this.dgCompras.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verDetalle});
            this.dgCompras.Location = new System.Drawing.Point(26, 189);
            this.dgCompras.MultiSelect = false;
            this.dgCompras.Name = "dgCompras";
            this.dgCompras.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCompras.Size = new System.Drawing.Size(541, 378);
            this.dgCompras.TabIndex = 91;
            this.dgCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompras_CellContentClick);
            // 
            // gbReporteVentas
            // 
            this.gbReporteVentas.Controls.Add(this.dtFechaHasta);
            this.gbReporteVentas.Controls.Add(this.iconButton1);
            this.gbReporteVentas.Controls.Add(this.lblFinal);
            this.gbReporteVentas.Controls.Add(this.dtFechaDesde);
            this.gbReporteVentas.Controls.Add(this.lblInicio);
            this.gbReporteVentas.Location = new System.Drawing.Point(25, 9);
            this.gbReporteVentas.Name = "gbReporteVentas";
            this.gbReporteVentas.Size = new System.Drawing.Size(695, 100);
            this.gbReporteVentas.TabIndex = 89;
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
            // btnReporteGeneral
            // 
            this.btnReporteGeneral.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteGeneral.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnReporteGeneral.IconColor = System.Drawing.Color.Black;
            this.btnReporteGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteGeneral.IconSize = 20;
            this.btnReporteGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteGeneral.Location = new System.Drawing.Point(952, 33);
            this.btnReporteGeneral.Name = "btnReporteGeneral";
            this.btnReporteGeneral.Size = new System.Drawing.Size(189, 55);
            this.btnReporteGeneral.TabIndex = 93;
            this.btnReporteGeneral.Text = "Reporte General";
            this.btnReporteGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteGeneral.UseVisualStyleBackColor = true;
            this.btnReporteGeneral.Click += new System.EventHandler(this.btnReporteGeneral_Click);
            // 
            // verDetalle
            // 
            this.verDetalle.HeaderText = "Ver Detalle";
            this.verDetalle.Name = "verDetalle";
            this.verDetalle.ReadOnly = true;
            this.verDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.verDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.btnReporteGeneral);
            this.Controls.Add(this.dgDetalleCompra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgCompras);
            this.Controls.Add(this.gbReporteVentas);
            this.Name = "FReporteCompras";
            this.Text = "Reporte Compras";
            this.Load += new System.EventHandler(this.FReporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).EndInit();
            this.gbReporteVentas.ResumeLayout(false);
            this.gbReporteVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetalleCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ComboBox cbNroCompra;
        private System.Windows.Forms.Label lblBuscar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dgCompras;
        private System.Windows.Forms.GroupBox gbReporteVentas;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label lblInicio;
        private FontAwesome.Sharp.IconButton btnReporteGeneral;
        private System.Windows.Forms.DataGridViewButtonColumn verDetalle;
    }
}