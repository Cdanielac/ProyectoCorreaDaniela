namespace CapaPresentacion.JCI
{
    partial class FRegistrarCompra
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
            this.lblNuevoProducto = new System.Windows.Forms.Label();
            this.dgCompras = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LBLtOTAL = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new FontAwesome.Sharp.IconButton();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.Solicitante = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbInfoProveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscarRazonSocial = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbCodProveedor = new System.Windows.Forms.ComboBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCodProducto = new FontAwesome.Sharp.IconButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.cbCodProducto = new System.Windows.Forms.ComboBox();
            this.BAgregar = new FontAwesome.Sharp.IconButton();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroCompra = new System.Windows.Forms.TextBox();
            this.lblNroCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).BeginInit();
            this.gbInfoCompra.SuspendLayout();
            this.gbInfoProveedor.SuspendLayout();
            this.gbInfoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNuevoProducto
            // 
            this.lblNuevoProducto.AutoSize = true;
            this.lblNuevoProducto.BackColor = System.Drawing.Color.Thistle;
            this.lblNuevoProducto.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNuevoProducto.Location = new System.Drawing.Point(463, 9);
            this.lblNuevoProducto.Name = "lblNuevoProducto";
            this.lblNuevoProducto.Size = new System.Drawing.Size(292, 40);
            this.lblNuevoProducto.TabIndex = 22;
            this.lblNuevoProducto.Text = "Registrar Compra";
            // 
            // dgCompras
            // 
            this.dgCompras.AllowUserToAddRows = false;
            this.dgCompras.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CNombre,
            this.CCantidad,
            this.CPrecioCompra,
            this.CSubtotal,
            this.CEliminar});
            this.dgCompras.Location = new System.Drawing.Point(444, 224);
            this.dgCompras.MultiSelect = false;
            this.dgCompras.Name = "dgCompras";
            this.dgCompras.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCompras.Size = new System.Drawing.Size(823, 285);
            this.dgCompras.TabIndex = 71;
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
            // CPrecioCompra
            // 
            this.CPrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPrecioCompra.HeaderText = "PRECIO COMPRA";
            this.CPrecioCompra.Name = "CPrecioCompra";
            this.CPrecioCompra.ReadOnly = true;
            // 
            // CSubtotal
            // 
            this.CSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CSubtotal.HeaderText = "SUBTOTAL";
            this.CSubtotal.Name = "CSubtotal";
            this.CSubtotal.ReadOnly = true;
            // 
            // CEliminar
            // 
            this.CEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CEliminar.HeaderText = "";
            this.CEliminar.Name = "CEliminar";
            this.CEliminar.ReadOnly = true;
            this.CEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(696, 533);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 20);
            this.textBox4.TabIndex = 82;
            // 
            // LBLtOTAL
            // 
            this.LBLtOTAL.AutoSize = true;
            this.LBLtOTAL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtOTAL.Location = new System.Drawing.Point(578, 530);
            this.LBLtOTAL.Name = "LBLtOTAL";
            this.LBLtOTAL.Size = new System.Drawing.Size(95, 22);
            this.LBLtOTAL.TabIndex = 81;
            this.LBLtOTAL.Text = "TOTAL: $";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.Color.White;
            this.btnGenerarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarFactura.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnGenerarFactura.IconColor = System.Drawing.Color.Green;
            this.btnGenerarFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarFactura.IconSize = 20;
            this.btnGenerarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarFactura.Location = new System.Drawing.Point(941, 520);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(170, 42);
            this.btnGenerarFactura.TabIndex = 39;
            this.btnGenerarFactura.Text = "Finalizar Compra";
            this.btnGenerarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.Controls.Add(this.comboBox1);
            this.gbInfoCompra.Controls.Add(this.comboBox2);
            this.gbInfoCompra.Controls.Add(this.lblFormaPago);
            this.gbInfoCompra.Controls.Add(this.txtSolicitante);
            this.gbInfoCompra.Controls.Add(this.txtFecha);
            this.gbInfoCompra.Controls.Add(this.Solicitante);
            this.gbInfoCompra.Controls.Add(this.lblTipoFactura);
            this.gbInfoCompra.Controls.Add(this.lblFecha);
            this.gbInfoCompra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.Location = new System.Drawing.Point(6, 68);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(749, 136);
            this.gbInfoCompra.TabIndex = 72;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "Información Compra";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 25);
            this.comboBox1.TabIndex = 91;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(524, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 25);
            this.comboBox2.TabIndex = 90;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.Location = new System.Drawing.Point(376, 77);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(136, 22);
            this.lblFormaPago.TabIndex = 89;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Enabled = false;
            this.txtSolicitante.Location = new System.Drawing.Point(524, 40);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(201, 25);
            this.txtSolicitante.TabIndex = 77;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(162, 37);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(201, 25);
            this.txtFecha.TabIndex = 75;
            // 
            // Solicitante
            // 
            this.Solicitante.AutoSize = true;
            this.Solicitante.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solicitante.Location = new System.Drawing.Point(410, 40);
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.Size = new System.Drawing.Size(96, 22);
            this.Solicitante.TabIndex = 74;
            this.Solicitante.Text = "Solicitante";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(14, 75);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(142, 22);
            this.lblTipoFactura.TabIndex = 73;
            this.lblTipoFactura.Text = "Tipo de Factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(96, 37);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 22);
            this.lblFecha.TabIndex = 72;
            this.lblFecha.Text = "Fecha";
            // 
            // gbInfoProveedor
            // 
            this.gbInfoProveedor.Controls.Add(this.btnBuscarRazonSocial);
            this.gbInfoProveedor.Controls.Add(this.textBox1);
            this.gbInfoProveedor.Controls.Add(this.cbCodProveedor);
            this.gbInfoProveedor.Controls.Add(this.lblRazonSocial);
            this.gbInfoProveedor.Controls.Add(this.lblCodigo);
            this.gbInfoProveedor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProveedor.Location = new System.Drawing.Point(761, 68);
            this.gbInfoProveedor.Name = "gbInfoProveedor";
            this.gbInfoProveedor.Size = new System.Drawing.Size(506, 136);
            this.gbInfoProveedor.TabIndex = 83;
            this.gbInfoProveedor.TabStop = false;
            this.gbInfoProveedor.Text = "Información Proveedor";
            // 
            // btnBuscarRazonSocial
            // 
            this.btnBuscarRazonSocial.BackColor = System.Drawing.Color.White;
            this.btnBuscarRazonSocial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarRazonSocial.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarRazonSocial.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarRazonSocial.IconColor = System.Drawing.Color.Gray;
            this.btnBuscarRazonSocial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarRazonSocial.IconSize = 15;
            this.btnBuscarRazonSocial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarRazonSocial.Location = new System.Drawing.Point(398, 77);
            this.btnBuscarRazonSocial.Name = "btnBuscarRazonSocial";
            this.btnBuscarRazonSocial.Size = new System.Drawing.Size(27, 26);
            this.btnBuscarRazonSocial.TabIndex = 81;
            this.btnBuscarRazonSocial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarRazonSocial.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(167, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 25);
            this.textBox1.TabIndex = 79;
            // 
            // cbCodProveedor
            // 
            this.cbCodProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodProveedor.FormattingEnabled = true;
            this.cbCodProveedor.Location = new System.Drawing.Point(167, 32);
            this.cbCodProveedor.Name = "cbCodProveedor";
            this.cbCodProveedor.Size = new System.Drawing.Size(225, 25);
            this.cbCodProveedor.TabIndex = 80;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(40, 79);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(117, 22);
            this.lblRazonSocial.TabIndex = 77;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(88, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 22);
            this.lblCodigo.TabIndex = 78;
            this.lblCodigo.Text = "Código";
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInfoProducto.Controls.Add(this.btnBuscarCodProducto);
            this.gbInfoProducto.Controls.Add(this.textBox3);
            this.gbInfoProducto.Controls.Add(this.lblCantidad);
            this.gbInfoProducto.Controls.Add(this.textBox2);
            this.gbInfoProducto.Controls.Add(this.lblPrecioCompra);
            this.gbInfoProducto.Controls.Add(this.txtProducto);
            this.gbInfoProducto.Controls.Add(this.cbCodProducto);
            this.gbInfoProducto.Controls.Add(this.BAgregar);
            this.gbInfoProducto.Controls.Add(this.lblProducto);
            this.gbInfoProducto.Controls.Add(this.label3);
            this.gbInfoProducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.Location = new System.Drawing.Point(6, 216);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(420, 347);
            this.gbInfoProducto.TabIndex = 84;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Información Producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Gray;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 15;
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.Location = new System.Drawing.Point(380, 111);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(27, 26);
            this.btnBuscarProducto.TabIndex = 89;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCodProducto
            // 
            this.btnBuscarCodProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarCodProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCodProducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCodProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarCodProducto.IconColor = System.Drawing.Color.Gray;
            this.btnBuscarCodProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCodProducto.IconSize = 15;
            this.btnBuscarCodProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCodProducto.Location = new System.Drawing.Point(380, 59);
            this.btnBuscarCodProducto.Name = "btnBuscarCodProducto";
            this.btnBuscarCodProducto.Size = new System.Drawing.Size(27, 26);
            this.btnBuscarCodProducto.TabIndex = 82;
            this.btnBuscarCodProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCodProducto.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 25);
            this.textBox3.TabIndex = 88;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(31, 198);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(85, 22);
            this.lblCantidad.TabIndex = 87;
            this.lblCantidad.Text = "Cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(149, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 25);
            this.textBox2.TabIndex = 86;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(53, 151);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(78, 22);
            this.lblPrecioCompra.TabIndex = 85;
            this.lblPrecioCompra.Text = "Precio $";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(149, 111);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(225, 25);
            this.txtProducto.TabIndex = 83;
            // 
            // cbCodProducto
            // 
            this.cbCodProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodProducto.FormattingEnabled = true;
            this.cbCodProducto.Location = new System.Drawing.Point(149, 59);
            this.cbCodProducto.Name = "cbCodProducto";
            this.cbCodProducto.Size = new System.Drawing.Size(225, 25);
            this.cbCodProducto.TabIndex = 84;
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.White;
            this.BAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAgregar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.ForeColor = System.Drawing.Color.Black;
            this.BAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BAgregar.IconColor = System.Drawing.Color.LimeGreen;
            this.BAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BAgregar.IconSize = 20;
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.Location = new System.Drawing.Point(149, 243);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(137, 48);
            this.BAgregar.TabIndex = 80;
            this.BAgregar.Text = "AGREGAR";
            this.BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAgregar.UseVisualStyleBackColor = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(31, 106);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(85, 22);
            this.lblProducto.TabIndex = 81;
            this.lblProducto.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 82;
            this.label3.Text = "Código";
            // 
            // txtNroCompra
            // 
            this.txtNroCompra.Enabled = false;
            this.txtNroCompra.Location = new System.Drawing.Point(137, 30);
            this.txtNroCompra.Name = "txtNroCompra";
            this.txtNroCompra.Size = new System.Drawing.Size(56, 20);
            this.txtNroCompra.TabIndex = 86;
            // 
            // lblNroCompra
            // 
            this.lblNroCompra.AutoSize = true;
            this.lblNroCompra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCompra.Location = new System.Drawing.Point(19, 27);
            this.lblNroCompra.Name = "lblNroCompra";
            this.lblNroCompra.Size = new System.Drawing.Size(124, 22);
            this.lblNroCompra.TabIndex = 85;
            this.lblNroCompra.Text = "Nro Compra: ";
            // 
            // FRegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.txtNroCompra);
            this.Controls.Add(this.lblNroCompra);
            this.Controls.Add(this.gbInfoProducto);
            this.Controls.Add(this.gbInfoProveedor);
            this.Controls.Add(this.gbInfoCompra);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LBLtOTAL);
            this.Controls.Add(this.lblNuevoProducto);
            this.Controls.Add(this.dgCompras);
            this.Controls.Add(this.btnGenerarFactura);
            this.Name = "FRegistrarCompra";
            this.Text = "Registrar Compra";
            this.Load += new System.EventHandler(this.FRegistrarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).EndInit();
            this.gbInfoCompra.ResumeLayout(false);
            this.gbInfoCompra.PerformLayout();
            this.gbInfoProveedor.ResumeLayout(false);
            this.gbInfoProveedor.PerformLayout();
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGenerarFactura;
        private System.Windows.Forms.Label lblNuevoProducto;
        private System.Windows.Forms.DataGridView dgCompras;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LBLtOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label Solicitante;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbInfoProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarRazonSocial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbCodProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private FontAwesome.Sharp.IconButton btnBuscarCodProducto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ComboBox cbCodProducto;
        private FontAwesome.Sharp.IconButton BAgregar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroCompra;
        private System.Windows.Forms.Label lblNroCompra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblFormaPago;
    }
}