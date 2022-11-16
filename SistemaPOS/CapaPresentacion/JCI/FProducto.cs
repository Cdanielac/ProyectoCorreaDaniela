using CapaDatos.Entity;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Administrador
{
    public partial class frmProducto : Form
    {
        int idUsuarioActual;
        public frmProducto(int pUsuario)
        {
            InitializeComponent();
            idUsuarioActual = pUsuario;
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

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtStock.Clear();
            txtStock.Clear();
            txtStockMinimo.Clear();
            txtPrecioVenta.Clear();
            txtDescripcion.Clear();
            cbCategoria.SelectedIndex = -1;
            cbProveedor.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            txtCodigo.Enabled = true;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            CN_Producto producto = new CN_Producto();
            if (String.IsNullOrWhiteSpace(txtCodigo.Text) || String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtStock.Text) || String.IsNullOrWhiteSpace(txtStockMinimo.Text)
                || String.IsNullOrWhiteSpace(txtPrecioVenta.Text) || String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDecimal(txtPrecioVenta.Text) <= 0 || Convert.ToInt32(txtStockMinimo.Text) > Convert.ToInt32(txtStock.Text))
            {
                if (Convert.ToDecimal(txtPrecioVenta.Text) <= 0)
                {
                    MessageBox.Show("Debe colocar un precio mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("El stock Minimo no puede ser mayor al stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            else
            {
                string mensaje = "Los datos serán guardados. ¿Está seguro?";
                string titulo = "Mensaje";
                var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (opcion == DialogResult.No)
                {
                    Limpiar();
                }
                else
                {
                    int codigoProducto = Convert.ToInt32(txtCodigo.Text);


                    if (producto.ProductoExiste(codigoProducto))
                    {
                        MessageBox.Show("El código ingresado ya pertenece a un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                        producto.agregarProducto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, cbCategoria.Text, cbProveedor.Text, Convert.ToInt32(txtStock.Text), Convert.ToInt32(txtStockMinimo.Text), Convert.ToDecimal(txtPrecioVenta.Text), txtDescripcion.Text, pEstado);
                        dgProducto.DataSource = producto.Listar();
                        MessageBox.Show("Nuevo Producto agregado con éxito.", "Nuevo Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            CN_Producto producto = new CN_Producto();
            CN_Categoria categoria = new CN_Categoria();
            CN_Proveedor proveedor = new CN_Proveedor();

            //dgProducto.Rows.Add("EDITAR");
            dgProducto.DataSource = producto.Listar();

            dgProducto.Columns["Editar"].DisplayIndex = 0;
            dgProducto.Columns["CODIGO"].DisplayIndex = 1;
            dgProducto.Columns["NOMBRE"].DisplayIndex = 2;
            dgProducto.Columns["CATEGORÍA"].DisplayIndex = 3;
            dgProducto.Columns["PROVEEDOR"].DisplayIndex = 4;
            dgProducto.Columns["STOCK"].DisplayIndex = 5;
            dgProducto.Columns["STOKMINIMO"].DisplayIndex = 6;
            dgProducto.Columns["PRECIOVENTA"].DisplayIndex = 7;
            dgProducto.Columns["DESCRIPCIÓN"].DisplayIndex = 8;
            dgProducto.Columns["ESTADO"].DisplayIndex = 9;

            dgProducto.Columns["Editar"].HeaderText = "EDITAR";
            dgProducto.Columns["STOKMINIMO"].HeaderText = "STOK MINIMO";
            dgProducto.Columns["PRECIOVENTA"].HeaderText = "PRECIO VENTA";

            Editar.Text = "EDITAR";
            Editar.UseColumnTextForButtonValue = true;

            List<Categoria> listaCategoria = categoria.ListaCategoria();
            foreach (var o_Categoria in listaCategoria)
            {
                cbCategoria.Items.Add(o_Categoria.descripcion.ToString());
            }
            this.cbCategoria.SelectedIndex = -1;

            List<Proveedor> listaProveedor = proveedor.ListaProveedor();
            foreach (var o_Proveedro in listaProveedor)
            {
                cbProveedor.Items.Add(o_Proveedro.razonSocial.ToString());
            }
            this.cbProveedor.SelectedIndex = -1;

            cbEstado.Items.Add("Inacctivo");
            cbEstado.Items.Add("Activo");

            this.cbEstado.SelectedIndex = -1;


            //Cargar detalles de filtro busqueda
            dgProducto.ClearSelection();

            cbFiltro.Items.Add("CODIGO");
            cbFiltro.Items.Add("NOMBRE");
            cbFiltro.Items.Add("CATEGORÍA");
            cbFiltro.Items.Add("PROVEEDOR");
            cbFiltro.Items.Add("STOCK");
            cbFiltro.Items.Add("ESTADO");

        }

        private void dgProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex < 0)
            //{
            //    return;
            //}
            //if (e.ColumnIndex == 0)
            //{
            //    dgProducto.Columns[10].Text = "EDITAR";
            //}

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_Producto productos = new CN_Producto();

            if (String.IsNullOrWhiteSpace(txtCodigo.Text) || String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtStock.Text) || String.IsNullOrWhiteSpace(txtStockMinimo.Text)
                || String.IsNullOrWhiteSpace(txtPrecioVenta.Text) || String.IsNullOrWhiteSpace(txtDescripcion.Text) || String.IsNullOrWhiteSpace(cbProveedor.Text) || String.IsNullOrWhiteSpace(cbCategoria.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToDecimal(txtPrecioVenta.Text) <= 0 || Convert.ToInt32(txtStockMinimo.Text) > Convert.ToInt32(txtStock.Text))
            {
                if (Convert.ToDecimal(txtPrecioVenta.Text) <= 0)
                {
                    MessageBox.Show("Debe colocar un precio mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("El stock Minimo no puede ser mayor al stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                string mensaje = "Los datos serán actualizados. ¿Está seguro?";
                string titulo = "Mensaje";
                var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (opcion == DialogResult.No)
                {
                    Limpiar();
                    txtCodigo.Enabled = true;
                }
                else
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    if (productos.ProductoExiste(codigo))
                    {
                        int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                        productos.editarProducto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, cbCategoria.Text, cbProveedor.Text, Convert.ToInt32(txtStock.Text), Convert.ToInt32(txtStockMinimo.Text), Convert.ToDecimal(txtPrecioVenta.Text), txtDescripcion.Text, pEstado);
                        dgProducto.DataSource = productos.Listar();
                        txtCodigo.Enabled = true;
                        Limpiar();
                        MessageBox.Show("Producto actualizado con éxito.", "Producto Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no pertenece a un producto existente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                }
            }

            
        }

        private void dgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProducto.Columns[e.ColumnIndex].Name == "Editar")
            {
                CN_Producto productos = new CN_Producto();
                CN_Categoria categorias = new CN_Categoria();
                CN_Proveedor proveedor = new CN_Proveedor();

                int codProducto= Convert.ToInt32(dgProducto.CurrentRow.Cells["CODIGO"].Value.ToString());

                Producto productoSelect = productos.UnProducto(codProducto);
                Categoria categoriaSelect = categorias.UnaCategoria(productoSelect.idCategoria);
                Proveedor proveedorSelect = proveedor.UnProveedorID(productoSelect.idProveedor);

                txtCodigo.Text = (productoSelect.codProducto).ToString();
                txtNombre.Text = productoSelect.nombre;
                cbCategoria.Text = categoriaSelect.descripcion;
                cbProveedor.Text = proveedorSelect.razonSocial;
                txtStock.Text = (productoSelect.stock).ToString();
                txtStockMinimo.Text = (productoSelect.stockMinimo).ToString();
                txtPrecioVenta.Text = (productoSelect.precioVenta).ToString(); ;
                txtDescripcion.Text = productoSelect.descripcion;
                this.cbEstado.SelectedIndex = Convert.ToInt32(productoSelect.estado);

                txtCodigo.Enabled = false;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Focus();
            string columnaFiltro = cbFiltro.Text;
            dgProducto.ClearSelection();

            if (dgProducto.Rows.Count > 0)
            {
                if (String.IsNullOrWhiteSpace(txtFiltro.Text) || String.IsNullOrWhiteSpace(cbFiltro.Text))
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dgProducto.Rows)
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
                                this.dgProducto.CurrentCell = null;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CN_Producto productos = new CN_Producto();

            txtFiltro.Focus();
            txtFiltro.Clear();
            cbFiltro.SelectedIndex = -1;
            dgProducto.DataSource = productos.Listar();
            dgProducto.ClearSelection();
        }
    }
}
