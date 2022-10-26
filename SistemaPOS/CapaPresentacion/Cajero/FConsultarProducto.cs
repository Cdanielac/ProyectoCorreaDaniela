using CapaDatos;
using CapaDatos.Entity;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Cajero
{
    public partial class FConsultarProducto : Form
    {
        public FConsultarProducto()
        {
            InitializeComponent();
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FConsultarProducto_Load(object sender, EventArgs e)
        {
            CN_Producto producto = new CN_Producto();

            dgProductos.DataSource = producto.ListarConsulta();
            
            txtFiltro.Focus();
            dgProductos.ClearSelection();

            cbFiltro.Items.Add("CODIGO");
            cbFiltro.Items.Add("NOMBRE");
            cbFiltro.Items.Add("CATEGORÍA");
        }

        private void Limpiar()
        {
            CN_Producto producto = new CN_Producto();

            txtFiltro.Clear();
            cbFiltro.SelectedIndex = -1;
            dgProductos.DataSource = producto.ListarConsulta();
           
            dgProductos.ClearSelection();
            txtFiltro.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = cbFiltro.Text;

            txtFiltro.Focus();
            dgProductos.ClearSelection();

            if (dgProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgProductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtFiltro.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        try
                        {
                        row.Visible = false;
                        }
                        catch(System.InvalidOperationException)
                        {

                        }
                    }
                }
            }
        }
    }
}
