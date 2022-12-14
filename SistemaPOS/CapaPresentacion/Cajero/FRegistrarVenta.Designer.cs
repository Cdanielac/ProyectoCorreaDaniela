namespace CapaPresentacion.Administrador
{
    partial class FRegistrarVenta
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.LBLtOTAL = new System.Windows.Forms.Label();
            this.dgVenta = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCajero = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbInfoVenta = new System.Windows.Forms.GroupBox();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.gbInfoCliente = new System.Windows.Forms.GroupBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new FontAwesome.Sharp.IconButton();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblApeyNomb = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.subtotalAnteriror = new System.Windows.Forms.Label();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGenerarFactura = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            this.gbInfoVenta.SuspendLayout();
            this.gbInfoCliente.SuspendLayout();
            this.gbInfoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(550, 477);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(225, 26);
            this.txtTotal.TabIndex = 93;
            // 
            // LBLtOTAL
            // 
            this.LBLtOTAL.AutoSize = true;
            this.LBLtOTAL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtOTAL.Location = new System.Drawing.Point(467, 481);
            this.LBLtOTAL.Name = "LBLtOTAL";
            this.LBLtOTAL.Size = new System.Drawing.Size(77, 17);
            this.LBLtOTAL.TabIndex = 92;
            this.LBLtOTAL.Text = "TOTAL: $";
            // 
            // dgVenta
            // 
            this.dgVenta.AllowUserToAddRows = false;
            this.dgVenta.AllowUserToDeleteRows = false;
            this.dgVenta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.CCodigo,
            this.CNombre,
            this.CCantidad,
            this.CPrecioVenta,
            this.CSubtotal,
            this.CStock,
            this.CEditar,
            this.CEliminar});
            this.dgVenta.Location = new System.Drawing.Point(442, 175);
            this.dgVenta.MultiSelect = false;
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVenta.Size = new System.Drawing.Size(667, 269);
            this.dgVenta.TabIndex = 86;
            this.dgVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVenta_CellContentClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "IdProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
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
            // CStock
            // 
            this.CStock.HeaderText = "STOCK";
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            this.CStock.Visible = false;
            // 
            // CEditar
            // 
            this.CEditar.HeaderText = "";
            this.CEditar.Name = "CEditar";
            this.CEditar.ReadOnly = true;
            this.CEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // txtCajero
            // 
            this.txtCajero.Enabled = false;
            this.txtCajero.Location = new System.Drawing.Point(443, 33);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new System.Drawing.Size(214, 25);
            this.txtCajero.TabIndex = 71;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(123, 33);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(204, 25);
            this.txtFecha.TabIndex = 10;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.ForeColor = System.Drawing.Color.White;
            this.lblCajero.Location = new System.Drawing.Point(345, 36);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(52, 17);
            this.lblCajero.TabIndex = 6;
            this.lblCajero.Text = "Cajero";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.ForeColor = System.Drawing.Color.White;
            this.lblTipoFactura.Location = new System.Drawing.Point(6, 82);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(111, 17);
            this.lblTipoFactura.TabIndex = 5;
            this.lblTipoFactura.Text = "Tipo de Factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(70, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // gbInfoVenta
            // 
            this.gbInfoVenta.Controls.Add(this.cbFormaPago);
            this.gbInfoVenta.Controls.Add(this.lblFormaPago);
            this.gbInfoVenta.Controls.Add(this.cbTipoFactura);
            this.gbInfoVenta.Controls.Add(this.txtCajero);
            this.gbInfoVenta.Controls.Add(this.lblFecha);
            this.gbInfoVenta.Controls.Add(this.lblCajero);
            this.gbInfoVenta.Controls.Add(this.lblTipoFactura);
            this.gbInfoVenta.Controls.Add(this.txtFecha);
            this.gbInfoVenta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoVenta.Location = new System.Drawing.Point(12, 23);
            this.gbInfoVenta.Name = "gbInfoVenta";
            this.gbInfoVenta.Size = new System.Drawing.Size(677, 136);
            this.gbInfoVenta.TabIndex = 94;
            this.gbInfoVenta.TabStop = false;
            this.gbInfoVenta.Text = "Información de Venta";
            this.gbInfoVenta.Enter += new System.EventHandler(this.gbInfoVenta_Enter);
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(445, 74);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(214, 25);
            this.cbFormaPago.TabIndex = 88;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.ForeColor = System.Drawing.Color.White;
            this.lblFormaPago.Location = new System.Drawing.Point(333, 82);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(106, 17);
            this.lblFormaPago.TabIndex = 87;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Location = new System.Drawing.Point(123, 77);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(204, 25);
            this.cbTipoFactura.TabIndex = 86;
            // 
            // gbInfoCliente
            // 
            this.gbInfoCliente.Controls.Add(this.txtDniCliente);
            this.gbInfoCliente.Controls.Add(this.btnBuscarNombre);
            this.gbInfoCliente.Controls.Add(this.txtCliente);
            this.gbInfoCliente.Controls.Add(this.lblApeyNomb);
            this.gbInfoCliente.Controls.Add(this.lblDNI);
            this.gbInfoCliente.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCliente.Location = new System.Drawing.Point(695, 23);
            this.gbInfoCliente.Name = "gbInfoCliente";
            this.gbInfoCliente.Size = new System.Drawing.Size(423, 136);
            this.gbInfoCliente.TabIndex = 95;
            this.gbInfoCliente.TabStop = false;
            this.gbInfoCliente.Text = "Información Cliente";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Enabled = false;
            this.txtDniCliente.Location = new System.Drawing.Point(139, 36);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(225, 25);
            this.txtDniCliente.TabIndex = 91;
            this.txtDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackColor = System.Drawing.Color.White;
            this.btnBuscarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNombre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarNombre.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarNombre.IconColor = System.Drawing.Color.Gray;
            this.btnBuscarNombre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarNombre.IconSize = 15;
            this.btnBuscarNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarNombre.Location = new System.Drawing.Point(373, 85);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(27, 26);
            this.btnBuscarNombre.TabIndex = 81;
            this.btnBuscarNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarNombre.UseVisualStyleBackColor = false;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(139, 85);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(225, 25);
            this.txtCliente.TabIndex = 79;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // lblApeyNomb
            // 
            this.lblApeyNomb.AutoSize = true;
            this.lblApeyNomb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeyNomb.ForeColor = System.Drawing.Color.White;
            this.lblApeyNomb.Location = new System.Drawing.Point(6, 85);
            this.lblApeyNomb.Name = "lblApeyNomb";
            this.lblApeyNomb.Size = new System.Drawing.Size(131, 17);
            this.lblApeyNomb.TabIndex = 77;
            this.lblApeyNomb.Text = "Apellido y Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(57, 41);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(36, 17);
            this.lblDNI.TabIndex = 78;
            this.lblDNI.Text = "DNI";
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Controls.Add(this.subtotalAnteriror);
            this.gbInfoProducto.Controls.Add(this.btnActualizar);
            this.gbInfoProducto.Controls.Add(this.lblId);
            this.gbInfoProducto.Controls.Add(this.lblNStock);
            this.gbInfoProducto.Controls.Add(this.lblStock);
            this.gbInfoProducto.Controls.Add(this.txtCodigo);
            this.gbInfoProducto.Controls.Add(this.txtCantidad);
            this.gbInfoProducto.Controls.Add(this.lblCantidad);
            this.gbInfoProducto.Controls.Add(this.txtPrecio);
            this.gbInfoProducto.Controls.Add(this.lblPrecioCompra);
            this.gbInfoProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInfoProducto.Controls.Add(this.txtProducto);
            this.gbInfoProducto.Controls.Add(this.btnAgregar);
            this.gbInfoProducto.Controls.Add(this.lblProducto);
            this.gbInfoProducto.Controls.Add(this.label3);
            this.gbInfoProducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.Location = new System.Drawing.Point(12, 165);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(414, 310);
            this.gbInfoProducto.TabIndex = 96;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Información Producto";
            // 
            // subtotalAnteriror
            // 
            this.subtotalAnteriror.AutoSize = true;
            this.subtotalAnteriror.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalAnteriror.Location = new System.Drawing.Point(16, 27);
            this.subtotalAnteriror.Name = "subtotalAnteriror";
            this.subtotalAnteriror.Size = new System.Drawing.Size(22, 22);
            this.subtotalAnteriror.TabIndex = 96;
            this.subtotalAnteriror.Text = "--";
            this.subtotalAnteriror.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnActualizar.IconColor = System.Drawing.Color.Navy;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 20;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(248, 253);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 48);
            this.btnActualizar.TabIndex = 92;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(53, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(79, 17);
            this.lblId.TabIndex = 95;
            this.lblId.Text = "idProducto";
            this.lblId.Visible = false;
            // 
            // lblNStock
            // 
            this.lblNStock.AutoSize = true;
            this.lblNStock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNStock.Location = new System.Drawing.Point(308, 21);
            this.lblNStock.Name = "lblNStock";
            this.lblNStock.Size = new System.Drawing.Size(22, 22);
            this.lblNStock.TabIndex = 94;
            this.lblNStock.Text = "--";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(245, 21);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 17);
            this.lblStock.TabIndex = 93;
            this.lblStock.Text = "Stock:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(139, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(225, 25);
            this.txtCodigo.TabIndex = 92;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(139, 203);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(225, 25);
            this.txtCantidad.TabIndex = 90;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(30, 203);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 17);
            this.lblCantidad.TabIndex = 89;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(139, 154);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(225, 25);
            this.txtPrecio.TabIndex = 88;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.ForeColor = System.Drawing.Color.White;
            this.lblPrecioCompra.Location = new System.Drawing.Point(43, 153);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(62, 17);
            this.lblPrecioCompra.TabIndex = 87;
            this.lblPrecioCompra.Text = "Precio $";
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(370, 113);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(27, 26);
            this.btnBuscarProducto.TabIndex = 86;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(139, 113);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(225, 25);
            this.txtProducto.TabIndex = 84;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 20;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(102, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 48);
            this.btnAgregar.TabIndex = 81;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(34, 112);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(67, 17);
            this.lblProducto.TabIndex = 82;
            this.lblProducto.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "Código";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack;
            this.btnCancelar.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(968, 468);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 42);
            this.btnCancelar.TabIndex = 97;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGenerarFactura.Location = new System.Drawing.Point(792, 468);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(170, 42);
            this.btnGenerarFactura.TabIndex = 85;
            this.btnGenerarFactura.Text = "Finalizar Venta";
            this.btnGenerarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // FRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 538);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbInfoProducto);
            this.Controls.Add(this.gbInfoCliente);
            this.Controls.Add(this.gbInfoVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.LBLtOTAL);
            this.Controls.Add(this.dgVenta);
            this.Controls.Add(this.btnGenerarFactura);
            this.Name = "FRegistrarVenta";
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.FRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
            this.gbInfoVenta.ResumeLayout(false);
            this.gbInfoVenta.PerformLayout();
            this.gbInfoCliente.ResumeLayout(false);
            this.gbInfoCliente.PerformLayout();
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label LBLtOTAL;
        private System.Windows.Forms.DataGridView dgVenta;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnGenerarFactura;
        private System.Windows.Forms.GroupBox gbInfoVenta;
        private System.Windows.Forms.GroupBox gbInfoCliente;
        private FontAwesome.Sharp.IconButton btnBuscarNombre;
        private System.Windows.Forms.Label lblApeyNomb;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioCompra;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private FontAwesome.Sharp.IconButton btnCancelar;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtProducto;
        public System.Windows.Forms.TextBox txtDniCliente;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblStock;
        public System.Windows.Forms.Label lblNStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewButtonColumn CEditar;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        public System.Windows.Forms.Label lblId;
        private FontAwesome.Sharp.IconButton btnActualizar;
        public System.Windows.Forms.Label subtotalAnteriror;
    }
}