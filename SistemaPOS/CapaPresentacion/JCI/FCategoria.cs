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

namespace CapaPresentacion.Administrador
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Limpiar()
        {
            txtCodCategoria.Clear();
            txtNombCategoria.Clear();
            this.cbEstado.SelectedIndex = -1;
            txtCodCategoria.Enabled = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Categoria categoria = new CN_Categoria();
            if (String.IsNullOrWhiteSpace(txtCodCategoria.Text) || String.IsNullOrWhiteSpace(txtNombCategoria.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mensaje = "Los datos serán guardados. ¿Está seguro?";
            string titulo = "Mensaje";
            var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.No)
            {
                Limpiar();
            }
            else
            {
                long codigoCategoria = long.Parse(txtCodCategoria.Text);


                if (categoria.CategoriaExiste(codigoCategoria))
                {
                    MessageBox.Show("El código ingresado ya pertenece a una categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);
                    categoria.agregarCategoria(codigoCategoria, txtNombCategoria.Text, pEstado);
                    dgCategoria.DataSource = categoria.Listar();
                    MessageBox.Show("Nueva Categoría agregada con éxito.", "Nueva Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void FCategoria_Load(object sender, EventArgs e)
        {
            CN_Categoria categoria = new CN_Categoria();

            dgCategoria.DataSource = categoria.Listar();

            dgCategoria.Columns["CODIGO"].DisplayIndex = 0;
            dgCategoria.Columns["NOMBRE"].DisplayIndex = 1;
            dgCategoria.Columns["ESTADO"].DisplayIndex = 2;
            dgCategoria.Columns["EDITAR"].DisplayIndex = 3;

            EDITAR.Text = "EDITAR";
            EDITAR.UseColumnTextForButtonValue = true;

            dgCategoria.Columns["idCategoria"].Visible = false;

            cbEstado.Items.Add("Inactivo");
            cbEstado.Items.Add("Activo");

            this.cbEstado.SelectedIndex = -1;

            cbFiltro.Items.Add("CODIGO");
            cbFiltro.Items.Add("NOMBRE");
            cbFiltro.Items.Add("ESTADO");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_Categoria categorias = new CN_Categoria();

            if (String.IsNullOrWhiteSpace(txtNombCategoria.Text) || String.IsNullOrWhiteSpace(txtCodCategoria.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mensaje = "Los datos serán actualizados. ¿Está seguro?";
            string titulo = "Mensaje";
            var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.No)
            {
                Limpiar();
                txtCodCategoria.Enabled = true;
            }
            else
            {
                long codigo = long.Parse(txtCodCategoria.Text);
                if (categorias.CategoriaExiste(codigo))
                {
                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                    categorias.editarCategoria(codigo, txtNombCategoria.Text, pEstado);
                    dgCategoria.DataSource = categorias.Listar();
                    txtCodCategoria.Enabled = true;
                    Limpiar();
                    MessageBox.Show("Categoria actualizado con éxito.", "Categoria Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("El código ingresado no pertenece a una categoría existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }   

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategoria.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                CN_Categoria categorias = new CN_Categoria();

                long codCategoria = long.Parse(dgCategoria.CurrentRow.Cells["idCategoria"].Value.ToString());

                Categoria categoriaSelect = categorias.UnaCategoria(codCategoria);

                txtCodCategoria.Text = (categoriaSelect.codCategoria).ToString();
                txtNombCategoria.Text = categoriaSelect.descripcion.ToString();
                this.cbEstado.SelectedIndex = Convert.ToInt32(categoriaSelect.estado);



                txtCodCategoria.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Focus();
            string columnaFiltro = cbFiltro.Text;
            dgCategoria.ClearSelection();

            if (dgCategoria.Rows.Count > 0)
            {
                if (String.IsNullOrWhiteSpace(txtFiltro.Text) || String.IsNullOrWhiteSpace(cbFiltro.Text))
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dgCategoria.Rows)
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
                                this.dgCategoria.CurrentCell = null;
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
            CN_Categoria categoria = new CN_Categoria();

            txtFiltro.Focus();
            txtFiltro.Clear();
            cbFiltro.SelectedIndex = -1;
            dgCategoria.DataSource = categoria.Listar();
            dgCategoria.ClearSelection();
        }
    }
}
