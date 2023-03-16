namespace CapaPresentacion
{
    partial class frmFacturaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTitulo = new System.Windows.Forms.GroupBox();
            this.gbContenedor1 = new System.Windows.Forms.GroupBox();
            this.gbContenedor2 = new System.Windows.Forms.GroupBox();
            this.gbContenedor3 = new System.Windows.Forms.GroupBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.gbContenedor5 = new System.Windows.Forms.GroupBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblTelefCliente = new System.Windows.Forms.Label();
            this.lblDirecCliente = new System.Windows.Forms.Label();
            this.lblNombCliente1 = new System.Windows.Forms.Label();
            this.lblDirecCliente1 = new System.Windows.Forms.Label();
            this.lblTelefCliente1 = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblTipoF = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbContenedor6 = new System.Windows.Forms.GroupBox();
            this.dgCompras = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LBLtOTAL = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblFormaP = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblFooter1 = new System.Windows.Forms.Label();
            this.lblFooter2 = new System.Windows.Forms.Label();
            this.btnDescargar = new FontAwesome.Sharp.IconButton();
            this.gbContenedor1.SuspendLayout();
            this.gbContenedor2.SuspendLayout();
            this.gbContenedor3.SuspendLayout();
            this.gbContenedor5.SuspendLayout();
            this.gbContenedor6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTitulo
            // 
            this.gbTitulo.BackgroundImage = global::CapaPresentacion.Properties.Resources.tira_logo3__1_;
            this.gbTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbTitulo.Location = new System.Drawing.Point(24, 53);
            this.gbTitulo.Name = "gbTitulo";
            this.gbTitulo.Size = new System.Drawing.Size(504, 94);
            this.gbTitulo.TabIndex = 0;
            this.gbTitulo.TabStop = false;
            // 
            // gbContenedor1
            // 
            this.gbContenedor1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbContenedor1.Controls.Add(this.lblFormaP);
            this.gbContenedor1.Controls.Add(this.lblFormaPago);
            this.gbContenedor1.Controls.Add(this.dateTimePicker1);
            this.gbContenedor1.Controls.Add(this.lblTipoF);
            this.gbContenedor1.Controls.Add(this.lblNro);
            this.gbContenedor1.Controls.Add(this.lblTipoFactura);
            this.gbContenedor1.Controls.Add(this.lblNroFactura);
            this.gbContenedor1.Controls.Add(this.lblFecha);
            this.gbContenedor1.ForeColor = System.Drawing.Color.White;
            this.gbContenedor1.Location = new System.Drawing.Point(534, 54);
            this.gbContenedor1.Name = "gbContenedor1";
            this.gbContenedor1.Size = new System.Drawing.Size(253, 94);
            this.gbContenedor1.TabIndex = 1;
            this.gbContenedor1.TabStop = false;
            // 
            // gbContenedor2
            // 
            this.gbContenedor2.BackColor = System.Drawing.Color.White;
            this.gbContenedor2.Controls.Add(this.lblTitulo1);
            this.gbContenedor2.Controls.Add(this.lblTelefono);
            this.gbContenedor2.Controls.Add(this.lblEmpresa);
            this.gbContenedor2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor2.Location = new System.Drawing.Point(24, 153);
            this.gbContenedor2.Name = "gbContenedor2";
            this.gbContenedor2.Size = new System.Drawing.Size(386, 114);
            this.gbContenedor2.TabIndex = 2;
            this.gbContenedor2.TabStop = false;
            this.gbContenedor2.Text = "Información de la Empresa";
            // 
            // gbContenedor3
            // 
            this.gbContenedor3.Controls.Add(this.dgCompras);
            this.gbContenedor3.Location = new System.Drawing.Point(24, 273);
            this.gbContenedor3.Name = "gbContenedor3";
            this.gbContenedor3.Size = new System.Drawing.Size(763, 206);
            this.gbContenedor3.TabIndex = 3;
            this.gbContenedor3.TabStop = false;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(17, 51);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(354, 19);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "DIRECCIÓN: Av. Libertad 345 -  Corrientes , Argentina";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(17, 80);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(177, 19);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "TELÉFONO: 3794540940\r\n";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(17, 22);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(331, 19);
            this.lblTitulo1.TabIndex = 2;
            this.lblTitulo1.Text = "IAR -ARTÍCULOS DE BAZAR Y DECORACIÓN";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(6, 49);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 19);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA: \r\n";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.ForeColor = System.Drawing.Color.White;
            this.lblNroFactura.Location = new System.Drawing.Point(6, 9);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(121, 19);
            this.lblNroFactura.TabIndex = 4;
            this.lblNroFactura.Text = "NRO FACTURA:";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.ForeColor = System.Drawing.Color.White;
            this.lblTipoFactura.Location = new System.Drawing.Point(6, 30);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(122, 19);
            this.lblTipoFactura.TabIndex = 5;
            this.lblTipoFactura.Text = "TIPO FACTURA:";
            // 
            // gbContenedor5
            // 
            this.gbContenedor5.BackColor = System.Drawing.Color.White;
            this.gbContenedor5.Controls.Add(this.lblTelefCliente1);
            this.gbContenedor5.Controls.Add(this.lblDirecCliente1);
            this.gbContenedor5.Controls.Add(this.lblNombCliente1);
            this.gbContenedor5.Controls.Add(this.lblNombreCliente);
            this.gbContenedor5.Controls.Add(this.lblTelefCliente);
            this.gbContenedor5.Controls.Add(this.lblDirecCliente);
            this.gbContenedor5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor5.Location = new System.Drawing.Point(432, 153);
            this.gbContenedor5.Name = "gbContenedor5";
            this.gbContenedor5.Size = new System.Drawing.Size(355, 114);
            this.gbContenedor5.TabIndex = 3;
            this.gbContenedor5.TabStop = false;
            this.gbContenedor5.Text = "Información del Cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(32, 22);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(79, 19);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "NOMBRE:";
            // 
            // lblTelefCliente
            // 
            this.lblTelefCliente.AutoSize = true;
            this.lblTelefCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefCliente.Location = new System.Drawing.Point(32, 80);
            this.lblTelefCliente.Name = "lblTelefCliente";
            this.lblTelefCliente.Size = new System.Drawing.Size(97, 19);
            this.lblTelefCliente.TabIndex = 1;
            this.lblTelefCliente.Text = "TELÉFONO: ";
            // 
            // lblDirecCliente
            // 
            this.lblDirecCliente.AutoSize = true;
            this.lblDirecCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecCliente.Location = new System.Drawing.Point(32, 51);
            this.lblDirecCliente.Name = "lblDirecCliente";
            this.lblDirecCliente.Size = new System.Drawing.Size(98, 19);
            this.lblDirecCliente.TabIndex = 0;
            this.lblDirecCliente.Text = "DIRECCIÓN:";
            // 
            // lblNombCliente1
            // 
            this.lblNombCliente1.AutoSize = true;
            this.lblNombCliente1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombCliente1.Location = new System.Drawing.Point(140, 22);
            this.lblNombCliente1.Name = "lblNombCliente1";
            this.lblNombCliente1.Size = new System.Drawing.Size(57, 19);
            this.lblNombCliente1.TabIndex = 3;
            this.lblNombCliente1.Text = "Cliente";
            // 
            // lblDirecCliente1
            // 
            this.lblDirecCliente1.AutoSize = true;
            this.lblDirecCliente1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecCliente1.Location = new System.Drawing.Point(139, 51);
            this.lblDirecCliente1.Name = "lblDirecCliente1";
            this.lblDirecCliente1.Size = new System.Drawing.Size(57, 19);
            this.lblDirecCliente1.TabIndex = 4;
            this.lblDirecCliente1.Text = "Cliente";
            // 
            // lblTelefCliente1
            // 
            this.lblTelefCliente1.AutoSize = true;
            this.lblTelefCliente1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefCliente1.Location = new System.Drawing.Point(138, 80);
            this.lblTelefCliente1.Name = "lblTelefCliente1";
            this.lblTelefCliente1.Size = new System.Drawing.Size(57, 19);
            this.lblTelefCliente1.TabIndex = 5;
            this.lblTelefCliente1.Text = "Cliente";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.ForeColor = System.Drawing.Color.White;
            this.lblNro.Location = new System.Drawing.Point(160, 9);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(34, 19);
            this.lblNro.TabIndex = 6;
            this.lblNro.Text = "Nro";
            // 
            // lblTipoF
            // 
            this.lblTipoF.AutoSize = true;
            this.lblTipoF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoF.ForeColor = System.Drawing.Color.White;
            this.lblTipoF.Location = new System.Drawing.Point(158, 28);
            this.lblTipoF.Name = "lblTipoF";
            this.lblTipoF.Size = new System.Drawing.Size(36, 19);
            this.lblTipoF.TabIndex = 7;
            this.lblTipoF.Text = "Tipo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // gbContenedor6
            // 
            this.gbContenedor6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbContenedor6.Controls.Add(this.lblFooter2);
            this.gbContenedor6.Controls.Add(this.lblFooter1);
            this.gbContenedor6.Controls.Add(this.lblFooter);
            this.gbContenedor6.ForeColor = System.Drawing.SystemColors.Control;
            this.gbContenedor6.Location = new System.Drawing.Point(24, 533);
            this.gbContenedor6.Name = "gbContenedor6";
            this.gbContenedor6.Size = new System.Drawing.Size(763, 75);
            this.gbContenedor6.TabIndex = 4;
            this.gbContenedor6.TabStop = false;
            // 
            // dgCompras
            // 
            this.dgCompras.AllowUserToAddRows = false;
            this.dgCompras.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CNombre,
            this.CCantidad,
            this.CPrecio,
            this.CSubtotal});
            this.dgCompras.Location = new System.Drawing.Point(35, 19);
            this.dgCompras.MultiSelect = false;
            this.dgCompras.Name = "dgCompras";
            this.dgCompras.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgCompras.Size = new System.Drawing.Size(684, 169);
            this.dgCompras.TabIndex = 87;
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
            // CPrecio
            // 
            this.CPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPrecio.HeaderText = "PRECIO";
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            // 
            // CSubtotal
            // 
            this.CSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CSubtotal.HeaderText = "SUBTOTAL";
            this.CSubtotal.Name = "CSubtotal";
            this.CSubtotal.ReadOnly = true;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(519, 485);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 20);
            this.textBox4.TabIndex = 95;
            // 
            // LBLtOTAL
            // 
            this.LBLtOTAL.AutoSize = true;
            this.LBLtOTAL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtOTAL.Location = new System.Drawing.Point(403, 485);
            this.LBLtOTAL.Name = "LBLtOTAL";
            this.LBLtOTAL.Size = new System.Drawing.Size(95, 22);
            this.LBLtOTAL.TabIndex = 94;
            this.LBLtOTAL.Text = "TOTAL: $";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.ForeColor = System.Drawing.Color.White;
            this.lblFormaPago.Location = new System.Drawing.Point(6, 69);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(141, 19);
            this.lblFormaPago.TabIndex = 9;
            this.lblFormaPago.Text = "FORMA DE PAGO: \r\n";
            // 
            // lblFormaP
            // 
            this.lblFormaP.AutoSize = true;
            this.lblFormaP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaP.ForeColor = System.Drawing.Color.White;
            this.lblFormaP.Location = new System.Drawing.Point(160, 69);
            this.lblFormaP.Name = "lblFormaP";
            this.lblFormaP.Size = new System.Drawing.Size(40, 19);
            this.lblFormaP.TabIndex = 10;
            this.lblFormaP.Text = "Pago";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(114, 16);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(572, 22);
            this.lblFooter.TabIndex = 3;
            this.lblFooter.Text = "IAR VENTA DE ARTÍCULOS DE BAZAR Y DECORACIÓN - 2022\r\n";
            // 
            // lblFooter1
            // 
            this.lblFooter1.AutoSize = true;
            this.lblFooter1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter1.ForeColor = System.Drawing.Color.White;
            this.lblFooter1.Location = new System.Drawing.Point(79, 43);
            this.lblFooter1.Name = "lblFooter1";
            this.lblFooter1.Size = new System.Drawing.Size(352, 22);
            this.lblFooter1.TabIndex = 3;
            this.lblFooter1.Text = " Av. Libertad 345 -  Corrientes , Argentina";
            // 
            // lblFooter2
            // 
            this.lblFooter2.AutoSize = true;
            this.lblFooter2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter2.ForeColor = System.Drawing.Color.White;
            this.lblFooter2.Location = new System.Drawing.Point(450, 43);
            this.lblFooter2.Name = "lblFooter2";
            this.lblFooter2.Size = new System.Drawing.Size(254, 22);
            this.lblFooter2.TabIndex = 3;
            this.lblFooter2.Text = " - Comunicate al: 3794540940\r\n";
            // 
            // btnDescargar
            // 
            this.btnDescargar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnDescargar.IconColor = System.Drawing.Color.Black;
            this.btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargar.IconSize = 20;
            this.btnDescargar.Location = new System.Drawing.Point(660, 15);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(109, 27);
            this.btnDescargar.TabIndex = 96;
            this.btnDescargar.Text = "DESCARGAR";
            this.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar.UseVisualStyleBackColor = true;
            // 
            // frmFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(810, 634);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.gbContenedor6);
            this.Controls.Add(this.LBLtOTAL);
            this.Controls.Add(this.gbContenedor5);
            this.Controls.Add(this.gbContenedor1);
            this.Controls.Add(this.gbContenedor3);
            this.Controls.Add(this.gbContenedor2);
            this.Controls.Add(this.gbTitulo);
            this.Name = "frmFacturaVenta";
            this.Text = "Factura de Venta";
            this.Load += new System.EventHandler(this.frmFacturaVenta_Load);
            this.gbContenedor1.ResumeLayout(false);
            this.gbContenedor1.PerformLayout();
            this.gbContenedor2.ResumeLayout(false);
            this.gbContenedor2.PerformLayout();
            this.gbContenedor3.ResumeLayout(false);
            this.gbContenedor5.ResumeLayout(false);
            this.gbContenedor5.PerformLayout();
            this.gbContenedor6.ResumeLayout(false);
            this.gbContenedor6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTitulo;
        private System.Windows.Forms.GroupBox gbContenedor1;
        private System.Windows.Forms.GroupBox gbContenedor2;
        private System.Windows.Forms.GroupBox gbContenedor3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTipoF;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox gbContenedor5;
        private System.Windows.Forms.Label lblTelefCliente1;
        private System.Windows.Forms.Label lblDirecCliente1;
        private System.Windows.Forms.Label lblNombCliente1;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblTelefCliente;
        private System.Windows.Forms.Label lblDirecCliente;
        private System.Windows.Forms.GroupBox gbContenedor6;
        private System.Windows.Forms.DataGridView dgCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubtotal;
        private System.Windows.Forms.Label lblFormaP;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LBLtOTAL;
        private System.Windows.Forms.Label lblFooter2;
        private System.Windows.Forms.Label lblFooter1;
        private System.Windows.Forms.Label lblFooter;
        private FontAwesome.Sharp.IconButton btnDescargar;
    }
}