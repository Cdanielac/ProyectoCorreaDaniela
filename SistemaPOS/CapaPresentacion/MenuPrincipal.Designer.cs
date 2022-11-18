namespace CapaPresentacion
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.LUser = new System.Windows.Forms.Label();
            this.MSTitulo = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbUser = new FontAwesome.Sharp.IconPictureBox();
            this.menuMenu = new System.Windows.Forms.MenuStrip();
            this.MUser = new FontAwesome.Sharp.IconMenuItem();
            this.MEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.MReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MOVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MOReportProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MAdmin = new FontAwesome.Sharp.IconMenuItem();
            this.MOClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MOBackUp = new FontAwesome.Sharp.IconMenuItem();
            this.MAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.MOEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.menuMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.TabIndex = 5;
            // 
            // Contenedor
            // 
            this.Contenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contenedor.BackColor = System.Drawing.Color.Transparent;
            this.Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Contenedor.ForeColor = System.Drawing.Color.Black;
            this.Contenedor.Location = new System.Drawing.Point(122, 94);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(0);
            this.Contenedor.MaximumSize = new System.Drawing.Size(1146, 577);
            this.Contenedor.MinimumSize = new System.Drawing.Size(1146, 577);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Contenedor.Size = new System.Drawing.Size(1146, 577);
            this.Contenedor.TabIndex = 6;
            // 
            // LUser
            // 
            this.LUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LUser.AutoSize = true;
            this.LUser.BackColor = System.Drawing.Color.Thistle;
            this.LUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUser.ForeColor = System.Drawing.Color.Transparent;
            this.LUser.Location = new System.Drawing.Point(1103, 28);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(60, 22);
            this.LUser.TabIndex = 10;
            this.LUser.Text = "LUser";
            // 
            // MSTitulo
            // 
            this.MSTitulo.AutoSize = false;
            this.MSTitulo.BackColor = System.Drawing.Color.Thistle;
            this.MSTitulo.Location = new System.Drawing.Point(0, 0);
            this.MSTitulo.Name = "MSTitulo";
            this.MSTitulo.Size = new System.Drawing.Size(1268, 95);
            this.MSTitulo.TabIndex = 7;
            this.MSTitulo.Text = "menuStrip1";
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
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.tira_logo3__1_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.Thistle;
            this.pbUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pbUser.IconColor = System.Drawing.Color.White;
            this.pbUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbUser.Location = new System.Drawing.Point(1065, 24);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(32, 32);
            this.pbUser.TabIndex = 20;
            this.pbUser.TabStop = false;
            // 
            // menuMenu
            // 
            this.menuMenu.BackColor = System.Drawing.Color.Thistle;
            this.menuMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MUser,
            this.MEmpleados,
            this.MReportes,
            this.MAdmin,
            this.MOBackUp,
            this.MAcercaDe});
            this.menuMenu.Location = new System.Drawing.Point(0, 95);
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Padding = new System.Windows.Forms.Padding(0);
            this.menuMenu.Size = new System.Drawing.Size(122, 577);
            this.menuMenu.TabIndex = 23;
            this.menuMenu.Text = "menuStrip1";
            // 
            // MUser
            // 
            this.MUser.AutoSize = false;
            this.MUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.MUser.IconColor = System.Drawing.Color.White;
            this.MUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MUser.IconSize = 50;
            this.MUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MUser.Name = "MUser";
            this.MUser.Size = new System.Drawing.Size(122, 69);
            this.MUser.Text = "Usuario";
            this.MUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MUser.Click += new System.EventHandler(this.MUsuarios_Click);
            // 
            // MEmpleados
            // 
            this.MEmpleados.AutoSize = false;
            this.MEmpleados.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEmpleados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MEmpleados.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.MEmpleados.IconColor = System.Drawing.Color.White;
            this.MEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MEmpleados.IconSize = 50;
            this.MEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MEmpleados.Name = "MEmpleados";
            this.MEmpleados.Size = new System.Drawing.Size(122, 69);
            this.MEmpleados.Text = "Empleados";
            this.MEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MEmpleados.Click += new System.EventHandler(this.MEmpleados_Click);
            // 
            // MReportes
            // 
            this.MReportes.AutoSize = false;
            this.MReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MOVentas,
            this.MOReportProductos,
            this.MOEmpleado});
            this.MReportes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MReportes.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.MReportes.IconColor = System.Drawing.Color.White;
            this.MReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MReportes.IconSize = 50;
            this.MReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MReportes.Name = "MReportes";
            this.MReportes.Size = new System.Drawing.Size(122, 69);
            this.MReportes.Text = "Reportes";
            this.MReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MOVentas
            // 
            this.MOVentas.Name = "MOVentas";
            this.MOVentas.Size = new System.Drawing.Size(180, 22);
            this.MOVentas.Text = "Ventas";
            this.MOVentas.Click += new System.EventHandler(this.MOVentas_Click);
            // 
            // MOReportProductos
            // 
            this.MOReportProductos.Name = "MOReportProductos";
            this.MOReportProductos.Size = new System.Drawing.Size(180, 22);
            this.MOReportProductos.Text = "Productos";
            this.MOReportProductos.Click += new System.EventHandler(this.MOReportProductos_Click);
            // 
            // MAdmin
            // 
            this.MAdmin.AutoSize = false;
            this.MAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MOClientes,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.MAdmin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MAdmin.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.MAdmin.IconColor = System.Drawing.Color.White;
            this.MAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MAdmin.IconSize = 50;
            this.MAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MAdmin.Name = "MAdmin";
            this.MAdmin.Size = new System.Drawing.Size(122, 69);
            this.MAdmin.Text = "Administrar";
            this.MAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MOClientes
            // 
            this.MOClientes.Name = "MOClientes";
            this.MOClientes.Size = new System.Drawing.Size(160, 22);
            this.MOClientes.Text = "Clientes";
            this.MOClientes.Click += new System.EventHandler(this.MOClientes_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.MOProveedores_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // MOBackUp
            // 
            this.MOBackUp.AutoSize = false;
            this.MOBackUp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MOBackUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MOBackUp.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.MOBackUp.IconColor = System.Drawing.Color.White;
            this.MOBackUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MOBackUp.IconSize = 50;
            this.MOBackUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MOBackUp.Name = "MOBackUp";
            this.MOBackUp.Size = new System.Drawing.Size(122, 69);
            this.MOBackUp.Text = "BackUp";
            this.MOBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MOBackUp.Click += new System.EventHandler(this.MOBackUp_Click);
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
            // MOEmpleado
            // 
            this.MOEmpleado.Name = "MOEmpleado";
            this.MOEmpleado.Size = new System.Drawing.Size(180, 22);
            this.MOEmpleado.Text = "Empleados";
            this.MOEmpleado.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 672);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menuMenu);
            this.Controls.Add(this.MSTitulo);
            this.MainMenuStrip = this.MSTitulo;
            this.MaximumSize = new System.Drawing.Size(1284, 711);
            this.MinimumSize = new System.Drawing.Size(1284, 711);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IAR";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.menuMenu.ResumeLayout(false);
            this.menuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.MenuStrip MSTitulo;
        private FontAwesome.Sharp.IconPictureBox pbUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.MenuStrip menuMenu;
        private FontAwesome.Sharp.IconMenuItem MUser;
        private FontAwesome.Sharp.IconMenuItem MEmpleados;
        private FontAwesome.Sharp.IconMenuItem MReportes;
        private System.Windows.Forms.ToolStripMenuItem MOVentas;
        private System.Windows.Forms.ToolStripMenuItem MOReportProductos;
        private FontAwesome.Sharp.IconMenuItem MOBackUp;
        private FontAwesome.Sharp.IconMenuItem MAcercaDe;
        private FontAwesome.Sharp.IconMenuItem MAdmin;
        private System.Windows.Forms.ToolStripMenuItem MOClientes;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MOEmpleado;
    }
}