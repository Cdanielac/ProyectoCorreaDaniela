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
                int codigoCategoria= Convert.ToInt32(txtCodCategoria.Text);


                if (categoria.CategoriaExiste(codigoCategoria))
                {
                    MessageBox.Show("El código ingresado ya pertenece a una categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {


                    categoria.agregarCategoria(Convert.ToInt32(txtCodCategoria.Text), txtNombCategoria.Text, Convert.ToInt32(cbEstado.Text));
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

            cbEstado.Items.Add(0.ToString());
            cbEstado.Items.Add(1.ToString());

            this.cbEstado.SelectedIndex = 1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
