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

namespace CapaPresentacion.Administrador
{
    public partial class FRegistrarVenta : Form
    {
        CN_Empleado empleado = new CN_Empleado();
        Empleado empleadoActual = new Empleado();
        public FRegistrarVenta(int pEmpleado)
        {
            empleadoActual = empleado.UnEmpleado(pEmpleado);
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            frmFacturaVenta form = new frmFacturaVenta();

            form.Show();
            this.Hide();
            form.FormClosing += Frm_closing;
        }

        private void FRegistrarVenta_Load(object sender, EventArgs e)
        {
            //CN_Venta venta = new CN_Venta();
            CN_Producto producto = new CN_Producto();
            CN_TipoFactura tipoFactura = new CN_TipoFactura();
            CN_FormaPago pago = new CN_FormaPago();
            CN_Cliente cliente = new CN_Cliente();

            txtCajero.Text = empleadoActual.apellido + " " + empleadoActual.nombre;
            txtFecha.Text = DateTime.Now.ToString();

            List<Producto> listaProducto = producto.ListaProducto();
            foreach (var unProducto in listaProducto)
            {
                cbCodProducto.Items.Add(unProducto.codProducto.ToString());
            }
            this.cbCodProducto.SelectedIndex = 0;

            Producto productoSelect = producto.UnProducto(Convert.ToInt32(cbCodProducto.Text));
            txtProducto.Text = productoSelect.nombre;
            txtPrecio.Text = productoSelect.precioVenta.ToString();


            List<TipoFactura> listaTipoFactura = tipoFactura.ListaTipoFactura();
            foreach (var unTipoFactura in listaTipoFactura)
            {
                cbTipoFactura.Items.Add(unTipoFactura.descripcion.ToString());
            }
            this.cbTipoFactura.SelectedIndex = 0;

            List<FormaPago> listaFormaPago = pago.ListaFormaPago();
            foreach (var unaFormaPago in listaFormaPago)
            {
                cbFormaPago.Items.Add(unaFormaPago.descripcion.ToString());
            }
            this.cbFormaPago.SelectedIndex = 0;

            List<Cliente> listaCliente = cliente.ListaCliente();
            foreach (var unCliente in listaCliente)
            {
                cbDNI.Items.Add(unCliente.dni.ToString());
            }
            this.cbDNI.SelectedIndex = 0;

            Cliente clienteSelect = cliente.UnCliente(Convert.ToInt32(cbDNI.Text));

            txtCliente.Text = clienteSelect.apellido + " " + clienteSelect.nombre;

        }

        private void dgVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad = Convert.ToInt32(txtCantidad.Text);

            if (cantidad > 0)
            {
                string mensaje = "El producto será agregado. ¿Está seguro?";
                string titulo = "Mensaje";
                var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (opcion == DialogResult.No)
                {
                    Limpiar();
                }
                else
                {
                    Decimal subtotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
                    dgVenta.Rows.Add(cbCodProducto.Text, txtProducto.Text, txtCantidad.Text, txtPrecio.Text, subtotal.ToString(), "Eliminar");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor para cantidad mayor a 0.", "Cantidad No válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Limpiar()
        {
            txtCantidad.Clear();

        }
    }
}
