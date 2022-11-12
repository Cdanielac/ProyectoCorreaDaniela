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
            this.gbRestauracion.SuspendLayout();
            this.gbBackUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelecionarPath
            // 
            this.lblSelecionarPath.AutoSize = true;
            this.lblSelecionarPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarPath.Location = new System.Drawing.Point(123, 77);
            this.lblSelecionarPath.Name = "lblSelecionarPath";
            this.lblSelecionarPath.Size = new System.Drawing.Size(265, 19);
            this.lblSelecionarPath.TabIndex = 1;
            this.lblSelecionarPath.Text = "Seleccionar archivo para restauración:";
            // 
            // gbRestauracion
            // 
            this.gbRestauracion.Controls.Add(this.btnBuscar);
            this.gbRestauracion.Controls.Add(this.btnRestaurar);
            this.gbRestauracion.Controls.Add(this.lblPath);
            this.gbRestauracion.Controls.Add(this.lblRuta);
            this.gbRestauracion.Controls.Add(this.lblSelecionarPath);
            this.gbRestauracion.Location = new System.Drawing.Point(105, 143);
            this.gbRestauracion.Name = "gbRestauracion";
            this.gbRestauracion.Size = new System.Drawing.Size(500, 327);
            this.gbRestauracion.TabIndex = 3;
            this.gbRestauracion.TabStop = false;
            this.gbRestauracion.Text = "Restauración:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Teal;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(115, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 39);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Enabled = false;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack;
            this.btnRestaurar.IconColor = System.Drawing.Color.Teal;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 30;
            this.btnRestaurar.Location = new System.Drawing.Point(276, 184);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(122, 39);
            this.btnRestaurar.TabIndex = 13;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(80, 131);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(387, 19);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "---------------------------------------------------------------";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(23, 133);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(51, 19);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "Ruta: ";
            // 
            // gbBackUp
            // 
            this.gbBackUp.Controls.Add(this.txtNombreArchivo);
            this.gbBackUp.Controls.Add(this.btnBuscar2);
            this.gbBackUp.Controls.Add(this.lblNombreArchivo);
            this.gbBackUp.Controls.Add(this.btnBackUp);
            this.gbBackUp.Controls.Add(this.txtPath);
            this.gbBackUp.Controls.Add(this.lblDirecBackUp);
            this.gbBackUp.Controls.Add(this.lblSeleccionarDirectorio);
            this.gbBackUp.Location = new System.Drawing.Point(656, 143);
            this.gbBackUp.Name = "gbBackUp";
            this.gbBackUp.Size = new System.Drawing.Size(508, 327);
            this.gbBackUp.TabIndex = 4;
            this.gbBackUp.TabStop = false;
            this.gbBackUp.Text = "BackUp";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(102, 143);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(360, 20);
            this.txtNombreArchivo.TabIndex = 13;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar2.IconColor = System.Drawing.Color.Teal;
            this.btnBuscar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar2.IconSize = 30;
            this.btnBuscar2.Location = new System.Drawing.Point(129, 184);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(122, 39);
            this.btnBuscar2.TabIndex = 15;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(29, 144);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(68, 19);
            this.lblNombreArchivo.TabIndex = 12;
            this.lblNombreArchivo.Text = "Nombre:";
            // 
            // btnBackUp
            // 
            this.btnBackUp.Enabled = false;
            this.btnBackUp.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnBackUp.IconColor = System.Drawing.Color.Teal;
            this.btnBackUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackUp.IconSize = 30;
            this.btnBackUp.Location = new System.Drawing.Point(293, 184);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(122, 39);
            this.btnBackUp.TabIndex = 12;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(102, 113);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(360, 20);
            this.txtPath.TabIndex = 11;
            // 
            // lblDirecBackUp
            // 
            this.lblDirecBackUp.AutoSize = true;
            this.lblDirecBackUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecBackUp.Location = new System.Drawing.Point(29, 114);
            this.lblDirecBackUp.Name = "lblDirecBackUp";
            this.lblDirecBackUp.Size = new System.Drawing.Size(51, 19);
            this.lblDirecBackUp.TabIndex = 8;
            this.lblDirecBackUp.Text = "Ruta: ";
            // 
            // lblSeleccionarDirectorio
            // 
            this.lblSeleccionarDirectorio.AutoSize = true;
            this.lblSeleccionarDirectorio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarDirectorio.Location = new System.Drawing.Point(164, 77);
            this.lblSeleccionarDirectorio.Name = "lblSeleccionarDirectorio";
            this.lblSeleccionarDirectorio.Size = new System.Drawing.Size(173, 19);
            this.lblSeleccionarDirectorio.TabIndex = 6;
            this.lblSeleccionarDirectorio.Text = "Seleccione un directorio:";
            // 
            // dlgPath
            // 
            this.dlgPath.FileName = "openFileDialog1";
            // 
            // FBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.gbBackUp);
            this.Controls.Add(this.gbRestauracion);
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
    }
}