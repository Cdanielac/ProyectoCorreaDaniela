using CapaDatos;
using CapaDatos.Entity;
using CapaNegocio;
using CapaPresentacion.Cajero;
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
        CN_Usuario usuario2 = new CN_Usuario();
        Empleado empleadoActual = new Empleado();
        Usuario usuarioActual = new Usuario();
        Decimal total;
        int idUsuario;
        public FRegistrarVenta(long pEmpleado, int pIdUsuario)
        {
            total = 0;
            empleadoActual = empleado.UnEmpleado(pEmpleado);
            idUsuario = pIdUsuario;
            usuarioActual = usuario2.UnUsuario(pEmpleado);
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

        private void limpiarInfoProducto()
        {
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtProducto.Clear();
            txtCodigo.Clear();
            lblNStock.Text = "--";
            subtotalAnteriror.Text = "--";
        }

        private void Limpiar()
        {

            limpiarInfoProducto();
            txtDniCliente.Clear();
            txtCliente.Clear();
            txtTotal.Clear();
            total = 0;

            dgVenta.Rows.Clear();

            cbFormaPago.SelectedIndex = -1;
            cbTipoFactura.SelectedIndex = -1;


        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (dgVenta.Rows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un producto.", "No se pudo generar la Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (String.IsNullOrWhiteSpace(cbTipoFactura.Text) || String.IsNullOrWhiteSpace(cbFormaPago.Text))
                {
                    MessageBox.Show("Debe seleccionar tipo de factura y/o forma de pago.", "No se pudo generar la Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //Variables
                    CN_Venta ventas = new CN_Venta();
                    DetalleVenta detalle = new DetalleVenta();
                    List<DetalleVenta> listaDetalle = new List<DetalleVenta>();
                    string tipoFactura, formaPago;
                    long clienteDni;
                    int ultimaVenta;
                    bool validaStock;
                    //asignación
                    tipoFactura = cbTipoFactura.Text;
                    formaPago = cbFormaPago.Text;
                    clienteDni = long.Parse(txtDniCliente.Text);
                    validaStock = true;

                    //se valida stock nuevamente
                    foreach (DataGridViewRow row in dgVenta.Rows)
                    {
                        int idp = Convert.ToInt32(row.Cells["idProducto"].Value);
                        int cant = Convert.ToInt32(row.Cells[3].Value);
                        if (!ventas.validarStock(idp, cant))
                        {
                            validaStock = false;
                        }
                    }

                    if (validaStock)
                    {
                        //Insertamos cabecera
                        DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                        ultimaVenta = ventas.agregarVenta(tipoFactura, idUsuario, clienteDni, formaPago, total, fecha);

                        foreach (DataGridViewRow row in dgVenta.Rows)
                        {
                            int idp, cant;
                            decimal subtotal;

                            idp = Convert.ToInt32(row.Cells["idProducto"].Value);
                            cant = Convert.ToInt32(row.Cells[3].Value);
                            subtotal = Convert.ToDecimal(row.Cells[5].Value);

                            //insertamos detalle
                            ventas.detalleVenta(ultimaVenta, idp, cant, subtotal);

                        }

                        Factura form = new Factura(ultimaVenta);

                        form.Show();
                        this.Hide();
                        form.FormClosing += Frm_closing;
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No hay stock paara uno/varios de los productos seleccionado.", "Error: No hay stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

           


        private void FRegistrarVenta_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            //Variables
            //CN_Venta venta = new CN_Venta();
            CN_Producto producto = new CN_Producto();
            CN_TipoFactura tipoFactura = new CN_TipoFactura();
            CN_FormaPago pago = new CN_FormaPago();
            CN_Cliente cliente = new CN_Cliente();

            //Datos Venta
            txtCajero.Text = empleadoActual.apellido + " " + empleadoActual.nombre;
            txtFecha.Text = DateTime.Now.Date.ToShortDateString();

            //List<Producto> listaProducto = producto.ListaProducto();
            //foreach (var unProducto in listaProducto)
            //{
                //cbCodProducto.Items.Add(unProducto.codProducto.ToString());
            //}
            //this.cbCodProducto.SelectedIndex = 0;

            //Producto productoSelect = producto.UnProducto(Convert.ToInt32(txtCodigo.Text));
            //txtProducto.Text = productoSelect.nombre;
            //txtPrecio.Text = productoSelect.precioVenta.ToString();

            //Tipo Factura
            List<TipoFactura> listaTipoFactura = tipoFactura.ListaTipoFactura();
            foreach (var unTipoFactura in listaTipoFactura)
            {
                cbTipoFactura.Items.Add(unTipoFactura.descripcion.ToString());
            }
            this.cbTipoFactura.SelectedIndex = -1;

            //Forma de Pago
            List<FormaPago> listaFormaPago = pago.ListaFormaPago();
            foreach (var unaFormaPago in listaFormaPago)
            {
                cbFormaPago.Items.Add(unaFormaPago.descripcion.ToString());
            }
            this.cbFormaPago.SelectedIndex = -1;


            //List<Cliente> listaCliente = cliente.ListaCliente();
            //foreach (var unCliente in listaCliente)
            //{
                //cbDNI.Items.Add(unCliente.dni.ToString());
            //}
            //this.cbDNI.SelectedIndex = 0;

            //Cliente clienteSelect = cliente.UnCliente(Convert.ToInt32(txtCodigo.Text));

            //txtCliente.Text = clienteSelect.apellido + " " + clienteSelect.nombre;

        }

        private void dgVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVenta.Columns[e.ColumnIndex].Name == "CEliminar")
            {
                decimal subtotal = Convert.ToDecimal(dgVenta.CurrentRow.Cells["CSubtotal"].Value.ToString());
                dgVenta.Rows.RemoveAt(dgVenta.CurrentRow.Index);
                
                total = total - subtotal;
                txtTotal.Text = total.ToString();
                limpiarInfoProducto();
            }

            if (dgVenta.Columns[e.ColumnIndex].Name == "CEditar")
            {
                subtotalAnteriror.Text = dgVenta.CurrentRow.Cells["CSubtotal"].Value.ToString();
                lblId.Text = dgVenta.CurrentRow.Cells["idProducto"].Value.ToString();
                txtCodigo.Text = dgVenta.CurrentRow.Cells["CCodigo"].Value.ToString();
                txtProducto.Text = dgVenta.CurrentRow.Cells["Cnombre"].Value.ToString();
                txtPrecio.Text = dgVenta.CurrentRow.Cells["CPrecioVenta"].Value.ToString();
                txtCantidad.Text = dgVenta.CurrentRow.Cells["CCantidad"].Value.ToString();
                lblNStock.Text = dgVenta.CurrentRow.Cells["CStock"].Value.ToString();
                btnActualizar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad = Convert.ToInt32(txtCantidad.Text);

            CN_Producto productos = new CN_Producto();
            Producto productoSelect = new Producto();
            productoSelect = productos.UnProducto(Convert.ToInt32(txtCodigo.Text));

            if (cantidad > 0)
            {
                if (cantidad <= productoSelect.stock)
                {
                    string mensaje = "El producto será agregado. ¿Está seguro?";
                    string titulo = "Mensaje";
                    var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (opcion == DialogResult.No)
                    {
                        limpiarInfoProducto();
                    }
                    else
                    {
                        bool existe = false;
                        long codigo = long.Parse(txtCodigo.Text);
                        foreach (DataGridViewRow row in dgVenta.Rows)
                        {
                            if (row.Cells["CCodigo"].Value.ToString().Trim().Contains(codigo.ToString()))
                            {
                                existe = true;
                            }
                        }
                        if (existe)
                        {
                            MessageBox.Show("El producto ya existe en el carrito.", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            Decimal subtotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
                            dgVenta.Rows.Add(lblId.Text,txtCodigo.Text, txtProducto.Text, txtCantidad.Text, txtPrecio.Text, subtotal.ToString(), lblNStock.Text, "Editar", "Eliminar");

                            total = total + (Convert.ToDecimal(productoSelect.precioVenta) * Convert.ToInt32(txtCantidad.Text));


                            txtTotal.Text = total.ToString();
                            limpiarInfoProducto();
                        }
                     }
                }
                else
                {
                    if (productoSelect.stock <= 0)
                    {
                        MessageBox.Show("No exite estock disponible para el producto seleccionado.", "Stock No disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No existe stock del produto para la cantidad seleccionada. Por favor ingrese un valor de cantidad menor.", "Stock No disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor para cantidad mayor a 0.", "Cantidad No válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "Todos los datos igresados seran borrados. ¿Está seguro?";
            string titulo = "Mensaje";
            var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (opcion == DialogResult.Yes)
            {
                Limpiar();

            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            //string mensaje = "El producto será agregado. ¿Está seguro?";
            //string titulo = "Mensaje";
            //var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            //if (opcion == DialogResult.No)
            //{
            //    Limpiar();
            //}

            FBuscarCliente form = new FBuscarCliente();
            AddOwnedForm(form);

            form.Show();
            this.Hide();
            form.FormClosing += Frm_closing;
        }


        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FBuscarProducto form = new FBuscarProducto(empleadoActual);
            AddOwnedForm(form);

            form.Show();
            this.Hide();
            form.FormClosing += Frm_closing;
        }
        
        public void Eliminar(long pcodigo)
        {
           
            foreach (DataGridViewRow row in dgVenta.Rows)
            {
                if (row.Cells["CCodigo"].Value.ToString().Trim().Contains(pcodigo.ToString()))
                {
                    dgVenta.Rows.RemoveAt(dgVenta.CurrentRow.Index);

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            CN_Producto productos = new CN_Producto();

            if (String.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            Producto productoSelect = new Producto();
            productoSelect = productos.UnProducto(Convert.ToInt32(txtCodigo.Text));

            if (cantidad > 0)
            {
                if (cantidad <= productoSelect.stock)
                {
                    string mensaje = "El producto será actualizado. ¿Está seguro?";
                    string titulo = "Mensaje";
                    var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                    if (opcion == DialogResult.No)
                    {
                        Limpiar();
                    }
                    else
                    {
                        bool existe = false;
                        long codigo = long.Parse(txtCodigo.Text);
                        foreach (DataGridViewRow row in dgVenta.Rows)
                        {
                            if (row.Cells["CCodigo"].Value.ToString().Trim().Contains(codigo.ToString()))
                            {
                                existe = true;
                            }
                        }
                        if (existe)
                        {
                            

                            total = total - Convert.ToDecimal(subtotalAnteriror.Text);

                            Decimal subtotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
                            total = total + (Convert.ToDecimal(productoSelect.precioVenta) * Convert.ToInt32(txtCantidad.Text));

                            Eliminar(codigo);

                            dgVenta.Rows.Add(lblId.Text, txtCodigo.Text, txtProducto.Text, txtCantidad.Text, txtPrecio.Text, subtotal.ToString(), lblNStock.Text, "Editar", "Eliminar");


                            txtTotal.Text = total.ToString();
                            limpiarInfoProducto();

                        }
                        else
                        {
                            string mensaje1 = "El producto todavía no fue agregado. ¿Desea hacerlo?";
                            string titulo1 = "Mensaje";
                            var opcion1 = MessageBox.Show(mensaje1, titulo1, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                            if (opcion1 == DialogResult.No)
                            {
                                limpiarInfoProducto();
                            }
                            else
                            {
                                btnAgregar_Click(sender,e);
                            }
                        }
                    }
                }
                else
                {
                    if (productoSelect.stock <= 0)
                    {
                        MessageBox.Show("No exite estock disponible para el producto seleccionado.", "Stock No disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No existe stock del produto para la cantidad seleccionada. Por favor ingrese un valor de cantidad menor.", "Stock No disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe ingresar un valor para cantidad mayor a 0.", "Cantidad No válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void gbInfoVenta_Enter(object sender, EventArgs e)
        {

        }
    }
}
