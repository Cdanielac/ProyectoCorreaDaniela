using CapaNegocio;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class FBackUp : Form
    {
        public FBackUp()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dlgPath.Filter = "SQL SERVER database backup files|*.bak";
            dlgPath.Title = "Database restore";
            if (dlgPath.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = dlgPath.FileName;
                btnRestaurar.Enabled = true;
            }

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            CN_BackUp backUp = new CN_BackUp();
            string mensaje = "Se restaurará la base de datos. ¿Está seguro?";
            string titulo = "Mensaje";
            var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.No)
            {
                LimpiarR();
            }
            else
            {
                if (lblPath.Text == "---------------------------------------------------------------")
                {
                    MessageBox.Show("Por favor ingrese la ubicación del directorio.");
                }
                else
                {
                    string ubicacion = lblPath.Text;
                    if (backUp.restaurarBD(ubicacion))
                    {
                        LimpiarR();
                        MessageBox.Show("Restauración de BD creada exitosamente.", "Restauración Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        LimpiarR();
                        MessageBox.Show("Restauración no creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
           

        }

        private void LimpiarB()
        {
            txtNombreArchivo.Clear();
            txtPath.Clear();
        }

        private void LimpiarR()
        {
            lblPath.Text = "---------------------------------------------------------------";
        }

        public void btnBackUp_Click(object sender, EventArgs e)
        {

            CN_BackUp backUp = new CN_BackUp();
            string mensaje = "Se creará BackUp de la Base de Datos. ¿Está seguro?";
            string titulo = "Mensaje";
            var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.No)
            {
                LimpiarB();
            }
            else
            {
                try
                {
                    if (txtPath.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor ingrese la ubicación del directorio.");
                    }
                    else
                    {
                        string ubicacion = txtPath.Text;
                        string nombre = txtNombreArchivo.Text + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss");
                        if (backUp.crearBackUp(nombre, ubicacion))
                        {
                            LimpiarB();
                            MessageBox.Show("Backup creado exitosamente.", "BackUp creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            LimpiarB();
                            MessageBox.Show("Backup no creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Backup no creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
           
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            
            if (fdlgPath.ShowDialog() == DialogResult.OK)
            {

                txtPath.Text = fdlgPath.SelectedPath; ;
                btnBackUp.Enabled = true;

            }
        }

        private void FBackUp_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            LimpiarR();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarB();
        }
    }
}
