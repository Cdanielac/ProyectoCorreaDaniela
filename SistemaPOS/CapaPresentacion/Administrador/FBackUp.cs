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
            CN_Conexion_DS backUp = new CN_Conexion_DS();
            //try
            //{
            if (lblPath.Text == "---------------------------------------------------------------")
            {
                MessageBox.Show("Por favor ingrese la ubicación del directorio.");
            }
            else
            {
                string ubicacion = lblPath.Text;
                if (backUp.restaurarBD(ubicacion))
                {
                    MessageBox.Show("Restauración de BD creada exitosamente.", "Restauración Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Restauración no creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            //}
            //catch
            //{
            //MessageBox.Show("Backup no creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //return;
            //}

        }

        SqlConnection cnx = new SqlConnection("Data Source = DESKTOP - C26D9LB; Initial Catalog = DB_POS; Integrated Security = True");

        private void btnBackUp_Click(object sender, EventArgs e)
        {

            CN_Conexion_DS backUp = new CN_Conexion_DS();
            //try
            //{
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
                        MessageBox.Show("Backup creado exitosamente.", "BackUp creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Backup no creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

            //}
            //catch
            //{
                //MessageBox.Show("Backup no creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return;
            //}
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
    }
}
