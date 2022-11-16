namespace CapaPresentacion.Administrador
{
    partial class FBackUp
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
            this.lblSelecionarPath = new System.Windows.Forms.Label();
            this.gbRestauracion = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnRestaurar = new FontAwesome.Sharp.IconButton();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.gbBackUp = new System.Windows.Forms.GroupBox();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnBuscar2 = new FontAwesome.Sharp.IconButton();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.btnBackUp = new FontAwesome.Sharp.IconButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblDirecBackUp = new System.Windows.Forms.Label();
            this.lblSeleccionarDirectorio = new System.Windows.Forms.Label();
            this.dlgPath = new System.Windows.Forms.OpenFileDialog();
            this.fdlgPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnCancelarR = new FontAwesome.Sharp.IconButton();
            this.gbRestauracion.SuspendLayout();
            this.gbBackUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelecionarPath
            // 
            this.lblSelecionarPath.AutoSize = true;
            this.lblSelecionarPath.BackColor = System.Drawing.Color.Thistle;
            this.lblSelecionarPath.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarPath.ForeColor = System.Drawing.Color.White;
            this.lblSelecionarPath.Location = new System.Drawing.Point(97, 77);
            this.lblSelecionarPath.Name = "lblSelecionarPath";
            this.lblSelecionarPath.Size = new System.Drawing.Size(327, 22);
            this.lblSelecionarPath.TabIndex = 1;
            this.lblSelecionarPath.Text = "Seleccionar archivo para restauración:";
            // 
            // gbRestauracion
            // 
            this.gbRestauracion.Controls.Add(this.btnCancelarR);
            this.gbRestauracion.Controls.Add(this.btnBuscar);
            this.gbRestauracion.Controls.Add(this.btnRestaurar);
            this.gbRestauracion.Controls.Add(this.lblPath);
            this.gbRestauracion.Controls.Add(this.lblRuta);
            this.gbRestauracion.Controls.Add(this.lblSelecionarPath);
            this.gbRestauracion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRestauracion.ForeColor = System.Drawing.Color.White;
            this.gbRestauracion.Location = new System.Drawing.Point(39, 114);
            this.gbRestauracion.Name = "gbRestauracion";
            this.gbRestauracion.Size = new System.Drawing.Size(500, 327);
            this.gbRestauracion.TabIndex = 3;
            this.gbRestauracion.TabStop = false;
            this.gbRestauracion.Text = "Restauración:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Teal;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(116, 199);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 39);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.White;
            this.btnRestaurar.Enabled = false;
            this.btnRestaurar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.Black;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack;
            this.btnRestaurar.IconColor = System.Drawing.Color.Teal;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 30;
            this.btnRestaurar.Location = new System.Drawing.Point(277, 199);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(122, 39);
            this.btnRestaurar.TabIndex = 13;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.Thistle;
            this.lblPath.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.White;
            this.lblPath.Location = new System.Drawing.Point(88, 141);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(388, 22);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "---------------------------------------------------------------";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.BackColor = System.Drawing.Color.Thistle;
            this.lblRuta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.White;
            this.lblRuta.Location = new System.Drawing.Point(22, 141);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(60, 22);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "Ruta: ";
            // 
            // gbBackUp
            // 
            this.gbBackUp.Controls.Add(this.btnCancelar);
            this.gbBackUp.Controls.Add(this.txtNombreArchivo);
            this.gbBackUp.Controls.Add(this.btnBuscar2);
            this.gbBackUp.Controls.Add(this.lblNombreArchivo);
            this.gbBackUp.Controls.Add(this.btnBackUp);
            this.gbBackUp.Controls.Add(this.txtPath);
            this.gbBackUp.Controls.Add(this.lblDirecBackUp);
            this.gbBackUp.Controls.Add(this.lblSeleccionarDirectorio);
            this.gbBackUp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBackUp.ForeColor = System.Drawing.Color.White;
            this.gbBackUp.Location = new System.Drawing.Point(590, 114);
            this.gbBackUp.Name = "gbBackUp";
            this.gbBackUp.Size = new System.Drawing.Size(508, 327);
            this.gbBackUp.TabIndex = 4;
            this.gbBackUp.TabStop = false;
            this.gbBackUp.Text = "BackUp";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(121, 151);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(360, 29);
            this.txtNombreArchivo.TabIndex = 13;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.White;
            this.btnBuscar2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar2.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar2.IconColor = System.Drawing.Color.Teal;
            this.btnBuscar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar2.IconSize = 30;
            this.btnBuscar2.Location = new System.Drawing.Point(140, 201);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(122, 39);
            this.btnBuscar2.TabIndex = 15;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.BackColor = System.Drawing.Color.Thistle;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.ForeColor = System.Drawing.Color.White;
            this.lblNombreArchivo.Location = new System.Drawing.Point(29, 152);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(81, 22);
            this.lblNombreArchivo.TabIndex = 12;
            this.lblNombreArchivo.Text = "Nombre:";
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.White;
            this.btnBackUp.Enabled = false;
            this.btnBackUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.Color.Black;
            this.btnBackUp.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnBackUp.IconColor = System.Drawing.Color.Teal;
            this.btnBackUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackUp.IconSize = 30;
            this.btnBackUp.Location = new System.Drawing.Point(291, 199);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(122, 39);
            this.btnBackUp.TabIndex = 12;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(121, 113);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(360, 29);
            this.txtPath.TabIndex = 11;
            // 
            // lblDirecBackUp
            // 
            this.lblDirecBackUp.AutoSize = true;
            this.lblDirecBackUp.BackColor = System.Drawing.Color.Thistle;
            this.lblDirecBackUp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecBackUp.ForeColor = System.Drawing.Color.White;
            this.lblDirecBackUp.Location = new System.Drawing.Point(29, 114);
            this.lblDirecBackUp.Name = "lblDirecBackUp";
            this.lblDirecBackUp.Size = new System.Drawing.Size(60, 22);
            this.lblDirecBackUp.TabIndex = 8;
            this.lblDirecBackUp.Text = "Ruta: ";
            // 
            // lblSeleccionarDirectorio
            // 
            this.lblSeleccionarDirectorio.AutoSize = true;
            this.lblSeleccionarDirectorio.BackColor = System.Drawing.Color.Thistle;
            this.lblSeleccionarDirectorio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarDirectorio.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionarDirectorio.Location = new System.Drawing.Point(164, 77);
            this.lblSeleccionarDirectorio.Name = "lblSeleccionarDirectorio";
            this.lblSeleccionarDirectorio.Size = new System.Drawing.Size(211, 22);
            this.lblSeleccionarDirectorio.TabIndex = 6;
            this.lblSeleccionarDirectorio.Text = "Seleccione un directorio:";
            // 
            // dlgPath
            // 
            this.dlgPath.FileName = "openFileDialog1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack;
            this.btnCancelar.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(191, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(166, 33);
            this.btnCancelar.TabIndex = 83;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCancelarR
            // 
            this.btnCancelarR.BackColor = System.Drawing.Color.White;
            this.btnCancelarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelarR.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarR.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarR.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack;
            this.btnCancelarR.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarR.IconSize = 20;
            this.btnCancelarR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarR.Location = new System.Drawing.Point(162, 257);
            this.btnCancelarR.Name = "btnCancelarR";
            this.btnCancelarR.Size = new System.Drawing.Size(166, 33);
            this.btnCancelarR.TabIndex = 84;
            this.btnCancelarR.Text = "CANCELAR";
            this.btnCancelarR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarR.UseVisualStyleBackColor = false;
            this.btnCancelarR.Click += new System.EventHandler(this.btnCancelarR_Click);
            // 
            // FBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 538);
            this.Controls.Add(this.gbBackUp);
            this.Controls.Add(this.gbRestauracion);
            this.MaximumSize = new System.Drawing.Size(1146, 577);
            this.MinimumSize = new System.Drawing.Size(1146, 577);
            this.Name = "FBackUp";
            this.Text = "FBackUp";
            this.Load += new System.EventHandler(this.FBackUp_Load);
            this.gbRestauracion.ResumeLayout(false);
            this.gbRestauracion.PerformLayout();
            this.gbBackUp.ResumeLayout(false);
            this.gbBackUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSelecionarPath;
        private System.Windows.Forms.GroupBox gbRestauracion;
        private System.Windows.Forms.GroupBox gbBackUp;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblDirecBackUp;
        private System.Windows.Forms.Label lblSeleccionarDirectorio;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private FontAwesome.Sharp.IconButton btnBuscar2;
        private FontAwesome.Sharp.IconButton btnBackUp;
        private System.Windows.Forms.OpenFileDialog dlgPath;
        private System.Windows.Forms.FolderBrowserDialog fdlgPath;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label lblNombreArchivo;
        private FontAwesome.Sharp.IconButton btnCancelarR;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}