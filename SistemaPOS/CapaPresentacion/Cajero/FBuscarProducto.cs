using CapaDatos;
using CapaDatos.Entity;
using CapaNegocio;
using CapaPresentacion.Administrador;
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
    public partial class FBuscarProducto : Form
    {
        Empleado empleadoActual;
        public FBuscarProducto(Empleado pEmpleado)
        {
            InitializeComponent();
            empleadoActual = pEmpleado;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Focus();
            string columnaFiltro = cbFiltro.Text;
            dgProductos.ClearSelection();

            if (dgProductos.Rows.Count > 0)
            {
                if (String.IsNullOrWhiteSpace(txtFiltro.Text) || String.IsNullOrWhiteSpace(cbFiltro.Text))
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dgProductos.Rows)
                    {
                        if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtFiltro.Text.Trim().ToUpper()))
                        {
                            row.Visible = true;
                            row.DefaultCellStyle.BackColor = Color.Thistle;
                        }
                        else
                        {
                            try
                            {
                                this.dgProductos.CurrentCell = null;
                                row.Visible = false;
                            }
                            catch (System.InvalidOperationException)
                            {

                            }
                        }
                    }
                }
            }
        }

        private void FBuscarProducto_Load(object sender, EventArgs e)
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

            txtFiltro.Focus();
            txtFiltro.Clear();
            cbFiltro.SelectedIndex = -1;
            dgProductos.DataSource = producto.ListarConsulta();
            dgProductos.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
            FRegistrarVenta frmRegistrarVenta = Owner as FRegistrarVenta;
            string idProducto = dgProductos.CurrentRow.Cells["IDPRODUCTO"].Value.ToString();
            string codigo = dgProductos.CurrentRow.Cells["CODIGO"].Value.ToString();
            string nombreProducto = dgProductos.CurrentRow.Cells["NOMBRE"].Value.ToString();
            string precio = dgProductos.CurrentRow.Cells["PRECIOVENTA"].Value.ToString();
            string stock = dgProductos.CurrentRow.Cells["STOCK"].Value.ToString();

            frmRegistrarVenta.lblId.Text = idProducto;
            frmRegistrarVenta.txtCodigo.Text = codigo;
            frmRegistrarVenta.txtProducto.Text = nombreProducto;
            frmRegistrarVenta.txtPrecio.Text = precio;
            frmRegistrarVenta.lblNStock.Text = stock;

            this.Close();
        }
    }
}
