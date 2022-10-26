﻿using CapaDatos;
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
        Empleado empleadoActual = new Empleado();
        Decimal total;
        public FRegistrarVenta(int pEmpleado)
        {
            total = 0;
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
            if (dgVenta.Rows.Count < 0)
            {
                MessageBox.Show("Debe seleccionar al menos un producto.", "No se pudo generar la Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmFacturaVenta form = new frmFacturaVenta(); //Factura de venta
                AddOwnedForm(form);

                CN_Cliente clientes = new CN_Cliente();
                Cliente clienteActual = new Cliente();
                clienteActual = clientes.UnCliente(Convert.ToInt32(txtDniCliente.Text));

                //Datos Factura

                //Datos Cajero
                form.lblInfoCajero.Text = this.txtCajero.Text;



                //Datos Cliente
                form.DNICliente1.Text = clienteActual.dni.ToString();
                form.lblNombCliente1.Text = this.txtCliente.Text;
                form.lblDirecCliente1.Text = clienteActual.direccion;
                form.lblTelefCliente1.Text = clienteActual.telefono.ToString();

                //Productos
                form.dgVentas.DataSource = this.dgVenta.DataSource;
                form.txtTotal.Text = this.txtTotal.Text.ToString();

                form.Show();
                this.Hide();
                form.FormClosing += Frm_closing;
            }
            
        }

        private void FRegistrarVenta_Load(object sender, EventArgs e)
        {
            //Variables
            //CN_Venta venta = new CN_Venta();
            CN_Producto producto = new CN_Producto();
            CN_TipoFactura tipoFactura = new CN_TipoFactura();
            CN_FormaPago pago = new CN_FormaPago();
            CN_Cliente cliente = new CN_Cliente();

            //Datos Venta
            txtCajero.Text = empleadoActual.apellido + " " + empleadoActual.nombre;
            txtFecha.Text = (DateTime.Now.Date).ToString();

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
                        Limpiar();
                    }
                    else
                    {
                        
                        Decimal subtotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecio.Text);
                        dgVenta.Rows.Add(txtCodigo.Text, txtProducto.Text, txtCantidad.Text, txtPrecio.Text, subtotal.ToString(), "Eliminar");

                        total = total + (Convert.ToDecimal(productoSelect.precioVenta) * Convert.ToInt32(txtCantidad.Text));


                        txtTotal.Text = total.ToString();
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

        private void Limpiar()
        {
            string mensaje = "Todos los datos igresados seran borrados. ¿Está seguro?";
            string titulo = "Mensaje";
            var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if(opcion == DialogResult.Yes)
            {
                txtCantidad.Clear();
                txtPrecio.Clear();
                txtProducto.Clear();
                txtCodigo.Clear();
                txtDniCliente.Clear();
                txtCliente.Clear();
                txtTotal.Clear();

                total =  0;

                dgVenta.Rows.Clear();

                cbFormaPago.SelectedIndex = -1;
                cbTipoFactura.SelectedIndex = -1;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
    }
}
