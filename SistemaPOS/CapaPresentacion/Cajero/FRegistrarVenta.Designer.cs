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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LBLtOTAL = new System.Windows.Forms.Label();
            this.lblRegistrarVenta = new System.Windows.Forms.Label();
            this.dgCompras = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNroVenta = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCajero = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new FontAwesome.Sharp.IconButton();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbInfoCliente = new System.Windows.Forms.GroupBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.txtApeYNombre = new System.Windows.Forms.TextBox();
            this.cbDNI = new System.Windows.Forms.ComboBox();
            this.lblApeyNomb = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.cbCodProducto = new System.Windows.Forms.ComboBox();
            this.BAgregar = new FontAwesome.Sharp.IconButton();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNroVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).BeginInit();
            this.gbInfoCompra.SuspendLayout();
            this.gbInfoCliente.SuspendLayout();
            this.gbInfoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(591, 533);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 20);
            this.textBox4.TabIndex = 93;
            // 
            // LBLtOTAL
            // 
            this.LBLtOTAL.AutoSize = true;
            this.LBLtOTAL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtOTAL.Location = new System.Drawing.Point(473, 530);
            this.LBLtOTAL.Name = "LBLtOTAL";
            this.LBLtOTAL.Size = new System.Drawing.Size(95, 22);
            this.LBLtOTAL.TabIndex = 92;
            this.LBLtOTAL.Text = "TOTAL: $";
            // 
            // lblRegistrarVenta
            // 
            this.lblRegistrarVenta.AutoSize = true;
            this.lblRegistrarVenta.BackColor = System.Drawing.Color.Thistle;
            this.lblRegistrarVenta.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegistrarVenta.Location = new System.Drawing.Point(485, 9);
            this.lblRegistrarVenta.Name = "lblRegistrarVenta";
            this.lblRegistrarVenta.Size = new System.Drawing.Size(255, 40);
            this.lblRegistrarVenta.TabIndex = 83;
            this.lblRegistrarVenta.Text = "Registrar Venta";
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
            this.CPrecioVenta,
            this.CSubtotal,
            this.CEliminar});
            this.dgCompras.Location = new System.Drawing.Point(445, 229);
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
            this.dgCompras.Size = new System.Drawing.Size(811, 285);
            this.dgCompras.TabIndex = 86;
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
            // CEliminar
            // 
            this.CEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CEliminar.HeaderText = "";
            this.CEliminar.Name = "CEliminar";
            this.CEliminar.ReadOnly = true;
            this.CEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtNroVenta
            // 
            this.txtNroVenta.Enabled = false;
            this.txtNroVenta.Location = new System.Drawing.Point(523, 36);
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.Size = new System.Drawing.Size(214, 25);
            this.txtNroVenta.TabIndex = 71;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(162, 36);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(204, 25);
            this.txtFecha.TabIndex = 10;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.Location = new System.Drawing.Point(450, 39);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(67, 22);
            this.lblCajero.TabIndex = 6;
            this.lblCajero.Text = "Cajero";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(14, 74);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(142, 22);
            this.lblTipoFactura.TabIndex = 5;
            this.lblTipoFactura.Text = "Tipo de Factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(96, 36);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 22);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
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
            this.btnGenerarFactura.Location = new System.Drawing.Point(836, 520);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(170, 42);
            this.btnGenerarFactura.TabIndex = 85;
            this.btnGenerarFactura.Text = "Finalizar Venta";
            this.btnGenerarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.Controls.Add(this.comboBox2);
            this.gbInfoCompra.Controls.Add(this.lblFormaPago);
            this.gbInfoCompra.Controls.Add(this.comboBox1);
            this.gbInfoCompra.Controls.Add(this.txtNroVenta);
            this.gbInfoCompra.Controls.Add(this.lblFecha);
            this.gbInfoCompra.Controls.Add(this.lblCajero);
            this.gbInfoCompra.Controls.Add(this.lblTipoFactura);
            this.gbInfoCompra.Controls.Add(this.txtFecha);
            this.gbInfoCompra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.Location = new System.Drawing.Point(10, 68);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Size = new System.Drawing.Size(755, 136);
            this.gbInfoCompra.TabIndex = 94;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "Información de Compra";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(523, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 25);
            this.comboBox2.TabIndex = 88;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.Location = new System.Drawing.Point(375, 77);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(136, 22);
            this.lblFormaPago.TabIndex = 87;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 25);
            this.comboBox1.TabIndex = 86;
            // 
            // gbInfoCliente
            // 
            this.gbInfoCliente.Controls.Add(this.iconButton4);
            this.gbInfoCliente.Controls.Add(this.txtApeYNombre);
            this.gbInfoCliente.Controls.Add(this.cbDNI);
            this.gbInfoCliente.Controls.Add(this.lblApeyNomb);
            this.gbInfoCliente.Controls.Add(this.lblDNI);
            this.gbInfoCliente.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCliente.Location = new System.Drawing.Point(771, 68);
            this.gbInfoCliente.Name = "gbInfoCliente";
            this.gbInfoCliente.Size = new System.Drawing.Size(485, 136);
            this.gbInfoCliente.TabIndex = 95;
            this.gbInfoCliente.TabStop = false;
            this.gbInfoCliente.Text = "Información Cliente";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Black;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton4.IconColor = System.Drawing.Color.Gray;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 15;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.Location = new System.Drawing.Point(414, 88);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(27, 26);
            this.iconButton4.TabIndex = 81;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // txtApeYNombre
            // 
            this.txtApeYNombre.Enabled = false;
            this.txtApeYNombre.Location = new System.Drawing.Point(183, 90);
            this.txtApeYNombre.Name = "txtApeYNombre";
            this.txtApeYNombre.Size = new System.Drawing.Size(225, 25);
            this.txtApeYNombre.TabIndex = 79;
            // 
            // cbDNI
            // 
            this.cbDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDNI.FormattingEnabled = true;
            this.cbDNI.Location = new System.Drawing.Point(183, 35);
            this.cbDNI.Name = "cbDNI";
            this.cbDNI.Size = new System.Drawing.Size(225, 25);
            this.cbDNI.TabIndex = 80;
            // 
            // lblApeyNomb
            // 
            this.lblApeyNomb.AutoSize = true;
            this.lblApeyNomb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeyNomb.Location = new System.Drawing.Point(15, 87);
            this.lblApeyNomb.Name = "lblApeyNomb";
            this.lblApeyNomb.Size = new System.Drawing.Size(162, 22);
            this.lblApeyNomb.TabIndex = 77;
            this.lblApeyNomb.Text = "Apellido y Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(79, 36);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(45, 22);
            this.lblDNI.TabIndex = 78;
            this.lblDNI.Text = "DNI";
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Controls.Add(this.iconButton1);
            this.gbInfoProducto.Controls.Add(this.textBox3);
            this.gbInfoProducto.Controls.Add(this.lblCantidad);
            this.gbInfoProducto.Controls.Add(this.textBox2);
            this.gbInfoProducto.Controls.Add(this.lblPrecioCompra);
            this.gbInfoProducto.Controls.Add(this.iconButton2);
            this.gbInfoProducto.Controls.Add(this.txtProducto);
            this.gbInfoProducto.Controls.Add(this.cbCodProducto);
            this.gbInfoProducto.Controls.Add(this.BAgregar);
            this.gbInfoProducto.Controls.Add(this.lblProducto);
            this.gbInfoProducto.Controls.Add(this.label3);
            this.gbInfoProducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.Location = new System.Drawing.Point(12, 224);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(414, 310);
            this.gbInfoProducto.TabIndex = 96;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Información Producto";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Gray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 15;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(370, 43);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(27, 26);
            this.iconButton1.TabIndex = 91;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 25);
            this.textBox3.TabIndex = 90;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(21, 182);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(85, 22);
            this.lblCantidad.TabIndex = 89;
            this.lblCantidad.Text = "Cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(139, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 25);
            this.textBox2.TabIndex = 88;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(43, 135);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(78, 22);
            this.lblPrecioCompra.TabIndex = 87;
            this.lblPrecioCompra.Text = "Precio $";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.Gray;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 15;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(368, 93);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(27, 26);
            this.iconButton2.TabIndex = 86;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(139, 95);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(225, 25);
            this.txtProducto.TabIndex = 84;
            // 
            // cbCodProducto
            // 
            this.cbCodProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodProducto.FormattingEnabled = true;
            this.cbCodProducto.Location = new System.Drawing.Point(139, 43);
            this.cbCodProducto.Name = "cbCodProducto";
            this.cbCodProducto.Size = new System.Drawing.Size(225, 25);
            this.cbCodProducto.TabIndex = 85;
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
            this.BAgregar.Location = new System.Drawing.Point(139, 227);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(137, 48);
            this.BAgregar.TabIndex = 81;
            this.BAgregar.Text = "AGREGAR";
            this.BAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAgregar.UseVisualStyleBackColor = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(21, 90);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(85, 22);
            this.lblProducto.TabIndex = 82;
            this.lblProducto.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 83;
            this.label3.Text = "Código";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(133, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 73;
            // 
            // lblNroVenta
            // 
            this.lblNroVenta.AutoSize = true;
            this.lblNroVenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVenta.Location = new System.Drawing.Point(24, 27);
            this.lblNroVenta.Name = "lblNroVenta";
            this.lblNroVenta.Size = new System.Drawing.Size(103, 22);
            this.lblNroVenta.TabIndex = 72;
            this.lblNroVenta.Text = "Nro Venta: ";
            // 
            // FRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbInfoProducto);
            this.Controls.Add(this.lblNroVenta);
            this.Controls.Add(this.gbInfoCliente);
            this.Controls.Add(this.gbInfoCompra);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LBLtOTAL);
            this.Controls.Add(this.lblRegistrarVenta);
            this.Controls.Add(this.dgCompras);
            this.Controls.Add(this.btnGenerarFactura);
            this.Name = "FRegistrarVenta";
            this.Text = "Registrar Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).EndInit();
            this.gbInfoCompra.ResumeLayout(false);
            this.gbInfoCompra.PerformLayout();
            this.gbInfoCliente.ResumeLayout(false);
            this.gbInfoCliente.PerformLayout();
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LBLtOTAL;
        private System.Windows.Forms.Label lblRegistrarVenta;
        private System.Windows.Forms.DataGridView dgCompras;
        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnGenerarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.GroupBox gbInfoCliente;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.TextBox txtApeYNombre;
        private System.Windows.Forms.ComboBox cbDNI;
        private System.Windows.Forms.Label lblApeyNomb;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPrecioCompra;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ComboBox cbCodProducto;
        private FontAwesome.Sharp.IconButton BAgregar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNroVenta;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}