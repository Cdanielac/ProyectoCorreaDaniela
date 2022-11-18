namespace CapaPresentacion.Cajero
{
    partial class MenuCajero
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
            this.menuMenu = new System.Windows.Forms.MenuStrip();
            this.MProducto = new FontAwesome.Sharp.IconMenuItem();
            this.MVentas = new FontAwesome.Sharp.IconMenuItem();
            this.MClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MFacturasVenta = new FontAwesome.Sharp.IconMenuItem();
            this.MAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.LUser = new System.Windows.Forms.Label();
            this.MSTitulo = new System.Windows.Forms.MenuStrip();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.menuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMenu
            // 
            this.menuMenu.BackColor = System.Drawing.Color.Thistle;
            this.menuMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MProducto,
            this.MVentas,
            this.MClientes,
            this.MFacturasVenta,
            this.MAcercaDe});
            this.menuMenu.Location = new System.Drawing.Point(0, 95);
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(128, 577);
            this.menuMenu.TabIndex = 11;
            this.menuMenu.Text = "menuStrip1";
            // 
            // MProducto
            // 
            this.MProducto.AutoSize = false;
            this.MProducto.BackColor = System.Drawing.Color.Thistle;
            this.MProducto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.MProducto.IconColor = System.Drawing.Color.White;
            this.MProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MProducto.IconSize = 50;
            this.MProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MProducto.Name = "MProducto";
            this.MProducto.Size = new System.Drawing.Size(122, 69);
            this.MProducto.Text = "Productos";
            this.MProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MProducto.Click += new System.EventHandler(this.MProductos_Click);
            // 
            // MVentas
            // 
            this.MVentas.AutoSize = false;
            this.MVentas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MVentas.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.MVentas.IconColor = System.Drawing.Color.White;
            this.MVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MVentas.IconSize = 50;
            this.MVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MVentas.Name = "MVentas";
            this.MVentas.Size = new System.Drawing.Size(122, 69);
            this.MVentas.Text = "Ventas";
            this.MVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MVentas.Click += new System.EventHandler(this.MVentas_Click);
            // 
            // MClientes
            // 
            this.MClientes.AutoSize = false;
            this.MClientes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.MClientes.IconColor = System.Drawing.Color.White;
            this.MClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MClientes.IconSize = 50;
            this.MClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MClientes.Name = "MClientes";
            this.MClientes.Size = new System.Drawing.Size(122, 69);
            this.MClientes.Text = "Clientes";
            this.MClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MClientes.Click += new System.EventHandler(this.MClientes_Click);
            // 
            // MFacturasVenta
            // 
            this.MFacturasVenta.AutoSize = false;
            this.MFacturasVenta.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFacturasVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MFacturasVenta.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.MFacturasVenta.IconColor = System.Drawing.Color.White;
            this.MFacturasVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MFacturasVenta.IconSize = 50;
            this.MFacturasVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MFacturasVenta.Name = "MFacturasVenta";
            this.MFacturasVenta.Size = new System.Drawing.Size(122, 69);
            this.MFacturasVenta.Text = "Facturas";
            this.MFacturasVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MFacturasVenta.Click += new System.EventHandler(this.MFacturasVenta_Click);
            // 
            // MAcercaDe
            // 
            this.MAcercaDe.AutoSize = false;
            this.MAcercaDe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAcercaDe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MAcercaDe.IconColor = System.Drawing.Color.White;
            this.MAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MAcercaDe.IconSize = 50;
            this.MAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MAcercaDe.Name = "MAcercaDe";
            this.MAcercaDe.Size = new System.Drawing.Size(122, 69);
            this.MAcercaDe.Text = "Acerca de ...";
            this.MAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MAcercaDe.Click += new System.EventHandler(this.MAcercaDe_Click);
            // 
            // LUser
            // 
            this.LUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LUser.AutoSize = true;
            this.LUser.BackColor = System.Drawing.Color.Thistle;
            this.LUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUser.ForeColor = System.Drawing.Color.Transparent;
            this.LUser.Location = new System.Drawing.Point(1100, 25);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(60, 22);
            this.LUser.TabIndex = 17;
            this.LUser.Text = "LUser";
            // 
            // MSTitulo
            // 
            this.MSTitulo.AutoSize = false;
            this.MSTitulo.BackColor = System.Drawing.Color.Thistle;
            this.MSTitulo.Location = new System.Drawing.Point(0, 0);
            this.MSTitulo.Name = "MSTitulo";
            this.MSTitulo.Size = new System.Drawing.Size(1268, 95);
            this.MSTitulo.TabIndex = 14;
            this.MSTitulo.Text = "menuStrip1";
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.Transparent;
            this.Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Contenedor.ForeColor = System.Drawing.Color.Black;
            this.Contenedor.Location = new System.Drawing.Point(128, 95);
            this.Contenedor.MaximumSize = new System.Drawing.Size(1146, 577);
            this.Contenedor.MinimumSize = new System.Drawing.Size(1146, 577);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1146, 577);
            this.Contenedor.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-197, -73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.tira_logo3__1_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.Thistle;
            this.pbUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pbUser.IconColor = System.Drawing.Color.White;
            this.pbUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbUser.Location = new System.Drawing.Point(1057, 20);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(32, 32);
            this.pbUser.TabIndex = 19;
            this.pbUser.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Thistle;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(27, 582);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 66);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 672);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuMenu);
            this.Controls.Add(this.MSTitulo);
            this.MaximumSize = new System.Drawing.Size(1284, 711);
            this.MinimumSize = new System.Drawing.Size(1284, 711);
            this.Name = "MenuCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Cajero";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuMenu.ResumeLayout(false);
            this.menuMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMenu;
        private FontAwesome.Sharp.IconMenuItem MVentas;
        private FontAwesome.Sharp.IconMenuItem MClientes;
        private FontAwesome.Sharp.IconMenuItem MFacturasVenta;
        private FontAwesome.Sharp.IconMenuItem MAcercaDe;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.MenuStrip MSTitulo;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox pbUser;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconMenuItem MProducto;
    }
}