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
            this.MProductos = new FontAwesome.Sharp.IconMenuItem();
            this.MVentas = new FontAwesome.Sharp.IconMenuItem();
            this.MClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MFacturasVenta = new FontAwesome.Sharp.IconMenuItem();
            this.MAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.LUser = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.MSTitulo = new System.Windows.Forms.MenuStrip();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMenu
            // 
            this.menuMenu.BackColor = System.Drawing.Color.Thistle;
            this.menuMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MProductos,
            this.MVentas,
            this.MClientes,
            this.MFacturasVenta,
            this.MAcercaDe});
            this.menuMenu.Location = new System.Drawing.Point(0, 67);
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(1279, 73);
            this.menuMenu.TabIndex = 11;
            this.menuMenu.Text = "menuStrip1";
            // 
            // MProductos
            // 
            this.MProductos.AutoSize = false;
            this.MProductos.Checked = true;
            this.MProductos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MProductos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MProductos.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.MProductos.IconColor = System.Drawing.Color.White;
            this.MProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MProductos.IconSize = 50;
            this.MProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MProductos.Name = "MProductos";
            this.MProductos.Size = new System.Drawing.Size(122, 69);
            this.MProductos.Text = "Productos";
            this.MProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MProductos.Click += new System.EventHandler(this.MProductos_Click);
            // 
            // MVentas
            // 
            this.MVentas.AutoSize = false;
            this.MVentas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MVentas.IconChar = FontAwesome.Sharp.IconChar.Industry;
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
            this.LUser.Location = new System.Drawing.Point(1158, 27);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(60, 22);
            this.LUser.TabIndex = 17;
            this.LUser.Text = "LUser";
            // 
            // lUsuario
            // 
            this.lUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lUsuario.AutoSize = true;
            this.lUsuario.BackColor = System.Drawing.Color.Thistle;
            this.lUsuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.lUsuario.Location = new System.Drawing.Point(1079, 27);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(79, 22);
            this.lUsuario.TabIndex = 16;
            this.lUsuario.Text = "Usuario:";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Thistle;
            this.LTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.LTitulo.Location = new System.Drawing.Point(26, 19);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(168, 31);
            this.LTitulo.TabIndex = 15;
            this.LTitulo.Text = "Sistema IAR ";
            // 
            // MSTitulo
            // 
            this.MSTitulo.AutoSize = false;
            this.MSTitulo.BackColor = System.Drawing.Color.Thistle;
            this.MSTitulo.Location = new System.Drawing.Point(0, 0);
            this.MSTitulo.Name = "MSTitulo";
            this.MSTitulo.Size = new System.Drawing.Size(1279, 67);
            this.MSTitulo.TabIndex = 14;
            this.MSTitulo.Text = "menuStrip1";
            // 
            // Contenedor
            // 
            this.Contenedor.ForeColor = System.Drawing.Color.Black;
            this.Contenedor.Location = new System.Drawing.Point(0, 143);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1279, 607);
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
            // MenuCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 751);
            this.Controls.Add(this.menuMenu);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.MSTitulo);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1295, 790);
            this.MinimumSize = new System.Drawing.Size(1295, 790);
            this.Name = "MenuCajero";
            this.Text = "Menu Cajero";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuMenu.ResumeLayout(false);
            this.menuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMenu;
        private FontAwesome.Sharp.IconMenuItem MProductos;
        private FontAwesome.Sharp.IconMenuItem MVentas;
        private FontAwesome.Sharp.IconMenuItem MClientes;
        private FontAwesome.Sharp.IconMenuItem MFacturasVenta;
        private FontAwesome.Sharp.IconMenuItem MAcercaDe;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.MenuStrip MSTitulo;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label1;
    }
}