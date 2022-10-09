using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Entity;
using CapaNegocio;

namespace CapaPresentacion.JCI
{
    public partial class FRegistrarCompra : Form
    {
        CN_Empleado empleado = new CN_Empleado();   
        Empleado empleadoActual = new Empleado();

        public FRegistrarCompra()
        {
            
            InitializeComponent();
        }

        public FRegistrarCompra(int pEmpleado)
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

        private void FRegistrarCompra_Load(object sender, EventArgs e)
        {
            CN_Compra compra = new CN_Compra();
            CN_Producto producto = new CN_Producto();
            CN_TipoFactura tipoFactura = new CN_TipoFactura();
            CN_FormaPago pago = new CN_FormaPago();
            CN_Proveedor proveedor = new CN_Proveedor();

            txtSolicitante.Text = empleadoActual.apellido + " " + empleadoActual.nombre;
            txtFecha.Text = DateTime.Now.ToString();

            List<Producto> listaProducto = producto.ListaProducto();
            foreach (var unProducto in listaProducto)
            {
                cbCodProducto.Items.Add(unProducto.codProducto.ToString());
            }
            this.cbCodProducto.SelectedIndex = 0;

            Producto productoSelect = producto.UnProducto(Convert.ToInt32(cbCodProducto.Text)); 
            txtProducto.Text = productoSelect.nombre;
            txtPrecio.Text = productoSelect.precioCompra.ToString();


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

            List<Proveedor> listaProveedor = proveedor.ListaProveedor();
            foreach (var unProveedor in listaProveedor)
            {
                cbCodProveedor.Items.Add(unProveedor.codProveedor.ToString());
            }
            this.cbCodProveedor.SelectedIndex = 0;

            Proveedor proveedorSelect = proveedor.UnProveedor(Convert.ToInt32(cbCodProveedor.Text));

            txtRazonSocial.Text = proveedorSelect.razonSocial;

        }

        private void BAgregar_Click(object sender, EventArgs e)
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
                    dgCompras.Rows.Add(cbCodProducto.Text, txtProducto.Text, txtCantidad.Text, txtPrecio.Text, subtotal.ToString(), "Eliminar");
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
