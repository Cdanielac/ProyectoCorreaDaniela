namespace CapaPresentacion.JCI
{
    partial class MenuJCI
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
            this.MMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.MOCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MOProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MCompras = new FontAwesome.Sharp.IconMenuItem();
            this.MProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.MFacturasCompras = new FontAwesome.Sharp.IconMenuItem();
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
            this.MMantenedor,
            this.MCompras,
            this.MProveedores,
            this.MFacturasCompras,
            this.MAcercaDe});
            this.menuMenu.Location = new System.Drawing.Point(0, 67);
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(1279, 73);
            this.menuMenu.TabIndex = 11;
            this.menuMenu.Text = "menuStrip1";
            // 
            // MMantenedor
            // 
            this.MMantenedor.AutoSize = false;
            this.MMantenedor.Checked = true;
            this.MMantenedor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MOCategoria,
            this.MOProducto});
            this.MMantenedor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMantenedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MMantenedor.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.MMantenedor.IconColor = System.Drawing.Color.White;
            this.MMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MMantenedor.IconSize = 50;
            this.MMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MMantenedor.Name = "MMantenedor";
            this.MMantenedor.Size = new System.Drawing.Size(122, 69);
            this.MMantenedor.Text = "Mantenedor";
            this.MMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MOCategoria
            // 
            this.MOCategoria.Name = "MOCategoria";
            this.MOCategoria.Size = new System.Drawing.Size(140, 22);
            this.MOCategoria.Text = "Categoría";
            this.MOCategoria.Click += new System.EventHandler(this.MOCategoria_Click);
            // 
            // MOProducto
            // 
            this.MOProducto.Name = "MOProducto";
            this.MOProducto.Size = new System.Drawing.Size(140, 22);
            this.MOProducto.Text = "Producto";
            this.MOProducto.Click += new System.EventHandler(this.MOProducto_Click);
            // 
            // MCompras
            // 
            this.MCompras.AutoSize = false;
            this.MCompras.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCompras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.MCompras.IconColor = System.Drawing.Color.White;
            this.MCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MCompras.IconSize = 50;
            this.MCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MCompras.Name = "MCompras";
            this.MCompras.Size = new System.Drawing.Size(122, 69);
            this.MCompras.Text = "Compras";
            this.MCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MCompras.Click += new System.EventHandler(this.MCompras_Click);
            // 
            // MProveedores
            // 
            this.MProveedores.AutoSize = false;
            this.MProveedores.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MProveedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.MProveedores.IconColor = System.Drawing.Color.White;
            this.MProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MProveedores.IconSize = 50;
            this.MProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MProveedores.Name = "MProveedores";
            this.MProveedores.Size = new System.Drawing.Size(122, 69);
            this.MProveedores.Text = "Proveedores";
            this.MProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MProveedores.Click += new System.EventHandler(this.MProveedores_Click);
            // 
            // MFacturasCompras
            // 
            this.MFacturasCompras.AutoSize = false;
            this.MFacturasCompras.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MFacturasCompras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MFacturasCompras.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.MFacturasCompras.IconColor = System.Drawing.Color.White;
            this.MFacturasCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MFacturasCompras.IconSize = 50;
            this.MFacturasCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MFacturasCompras.Name = "MFacturasCompras";
            this.MFacturasCompras.Size = new System.Drawing.Size(122, 69);
            this.MFacturasCompras.Text = "Facturas";
            this.MFacturasCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MFacturasCompras.Click += new System.EventHandler(this.MFacturasCompras_Click);
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
            this.LUser.Location = new System.Drawing.Point(1165, 28);
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
            this.lUsuario.Location = new System.Drawing.Point(1086, 28);
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
            this.Contenedor.Size = new System.Drawing.Size(1279, 613);
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
            // MenuJCI
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
            this.Name = "MenuJCI";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuMenu.ResumeLayout(false);
            this.menuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMenu;
        private FontAwesome.Sharp.IconMenuItem MMantenedor;
        private System.Windows.Forms.ToolStripMenuItem MOCategoria;
        private System.Windows.Forms.ToolStripMenuItem MOProducto;
        private FontAwesome.Sharp.IconMenuItem MCompras;
        private FontAwesome.Sharp.IconMenuItem MProveedores;
        private FontAwesome.Sharp.IconMenuItem MFacturasCompras;
        private FontAwesome.Sharp.IconMenuItem MAcercaDe;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.MenuStrip MSTitulo;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label1;
    }
}