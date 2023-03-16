namespace CapaPresentacion.Administrador
{
    partial class frmCategoria
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
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.LTUsuario = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.txtNombCategoria = new System.Windows.Forms.TextBox();
            this.lblCodigoCat = new System.Windows.Forms.Label();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.EDITAR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToAddRows = false;
            this.dgCategoria.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgCategoria.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR});
            this.dgCategoria.Location = new System.Drawing.Point(690, 129);
            this.dgCategoria.MultiSelect = false;
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCategoria.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCategoria.Size = new System.Drawing.Size(443, 281);
            this.dgCategoria.TabIndex = 69;
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.cbEstado);
            this.gbContenedor.Controls.Add(this.lblEstado);
            this.gbContenedor.Controls.Add(this.LTUsuario);
            this.gbContenedor.Controls.Add(this.iconPictureBox1);
            this.gbContenedor.Controls.Add(this.btnActualizar);
            this.gbContenedor.Controls.Add(this.btnAgregar);
            this.gbContenedor.Controls.Add(this.txtNombCategoria);
            this.gbContenedor.Controls.Add(this.lblCodigoCat);
            this.gbContenedor.Controls.Add(this.txtCodCategoria);
            this.gbContenedor.Controls.Add(this.lblNombre);
            this.gbContenedor.Location = new System.Drawing.Point(150, 122);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(480, 288);
            this.gbContenedor.TabIndex = 70;
            this.gbContenedor.TabStop = false;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(185, 151);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(229, 21);
            this.cbEstado.TabIndex = 80;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(96, 150);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 22);
            this.lblEstado.TabIndex = 79;
            this.lblEstado.Text = "Estado";
            // 
            // LTUsuario
            // 
            this.LTUsuario.AutoSize = true;
            this.LTUsuario.BackColor = System.Drawing.Color.Thistle;
            this.LTUsuario.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LTUsuario.Location = new System.Drawing.Point(142, 21);
            this.LTUsuario.Name = "LTUsuario";
            this.LTUsuario.Size = new System.Drawing.Size(272, 40);
            this.LTUsuario.TabIndex = 77;
            this.LTUsuario.Text = "Nueva Categoría";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Thistle;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(91, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 78;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.btnActualizar.IconColor = System.Drawing.Color.MediumBlue;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 20;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(60, 205);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(166, 33);
            this.btnActualizar.TabIndex = 73;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnAgregar.IconColor = System.Drawing.Color.LimeGreen;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 20;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(248, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 33);
            this.btnAgregar.TabIndex = 71;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombCategoria
            // 
            this.txtNombCategoria.Location = new System.Drawing.Point(185, 116);
            this.txtNombCategoria.Name = "txtNombCategoria";
            this.txtNombCategoria.Size = new System.Drawing.Size(229, 20);
            this.txtNombCategoria.TabIndex = 76;
            // 
            // lblCodigoCat
            // 
            this.lblCodigoCat.AutoSize = true;
            this.lblCodigoCat.BackColor = System.Drawing.SystemColors.Control;
            this.lblCodigoCat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCat.Location = new System.Drawing.Point(94, 82);
            this.lblCodigoCat.Name = "lblCodigoCat";
            this.lblCodigoCat.Size = new System.Drawing.Size(69, 22);
            this.lblCodigoCat.TabIndex = 72;
            this.lblCodigoCat.Text = "Código";
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Location = new System.Drawing.Point(185, 85);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(229, 20);
            this.txtCodCategoria.TabIndex = 75;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(87, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 22);
            this.lblNombre.TabIndex = 74;
            this.lblNombre.Text = "Nombre";
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            this.EDITAR.Text = "EDITAR";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.gbContenedor);
            this.Controls.Add(this.dgCategoria);
            this.Name = "frmCategoria";
            this.Text = "FCategoria";
            this.Load += new System.EventHandler(this.FCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label LTUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.TextBox txtNombCategoria;
        private System.Windows.Forms.Label lblCodigoCat;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewButtonColumn EDITAR;
    }
}