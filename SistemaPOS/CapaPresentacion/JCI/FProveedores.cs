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

namespace CapaPresentacion.Administrador
{
    public partial class frmProveedores : Form
    {
        Usuario usuActual;
        int idUsuaurioActual;
        public frmProveedores(Usuario pUsuario)
        {
            InitializeComponent();
            usuActual = pUsuario;
            idUsuaurioActual = pUsuario.idUsuario;
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
            txtCodProveedor.Clear();
            txtRazonSocial.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            this.cbEstado.SelectedIndex = 1;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Proveedor proveedor = new CN_Proveedor();
            if (String.IsNullOrWhiteSpace(txtCodProveedor.Text) || String.IsNullOrWhiteSpace(txtRazonSocial.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text)
                || String.IsNullOrWhiteSpace(txtDireccion.Text))
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
                long codigoProveedor = long.Parse(txtCodProveedor.Text);


                if (proveedor.ProveedorExiste(codigoProveedor))
                {
                    MessageBox.Show("El código ingresado ya pertenece a un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    long codigoProveedor1 = long.Parse(txtCodProveedor.Text);
                    int telf = Convert.ToInt32(txtTelefono.Text);
                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                    proveedor.agregarProveedor(codigoProveedor1, txtRazonSocial.Text, txtEmail.Text, telf, txtDireccion.Text, pEstado);
                    dgProveedor.DataSource = proveedor.Listar();
                    MessageBox.Show("Nuevo Proveedor agregado con éxito.", "Nuevo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void FProveedores_Load(object sender, EventArgs e)
        {
            CN_Proveedor proveedores = new CN_Proveedor();

            dgProveedor.DataSource = proveedores.Listar();

            cbEstado.Items.Add("Inactivo");
            cbEstado.Items.Add("Activo");

            this.cbEstado.SelectedIndex = 1;

            Editar.Text = "EDITAR";
            Editar.UseColumnTextForButtonValue = true;

            if(usuActual.idRol != 1)
            {
                cbEstado.Enabled = false;
            }

        }

        private void dgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProveedor.Columns[e.ColumnIndex].Name == "Editar")
            {
                CN_Proveedor proveedor = new CN_Proveedor();

                long codProveedor = long.Parse(dgProveedor.CurrentRow.Cells["CODIGO"].Value.ToString());

                Proveedor proveedorSelect = proveedor.UnProveedor(codProveedor);

                txtCodProveedor.Text = (proveedorSelect.codProveedor).ToString();
                txtRazonSocial.Text = proveedorSelect.razonSocial;
                txtEmail.Text = proveedorSelect.email;
                txtDireccion.Text = proveedorSelect.direccion;
                txtTelefono.Text = (proveedorSelect.telefono).ToString();
                cbEstado.Text = proveedorSelect.estado == 1 ? "Activo" : "Inactivo";

                txtCodProveedor.Enabled = false;

            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_Proveedor proveedor = new CN_Proveedor();

            if (String.IsNullOrWhiteSpace(txtCodProveedor.Text) || String.IsNullOrWhiteSpace(txtRazonSocial.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtDireccion.Text) ||  String.IsNullOrWhiteSpace(txtTelefono.Text))
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
                txtCodProveedor.Enabled = true;
            }
            else
            {
                int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);
                long cod = long.Parse(txtCodProveedor.Text);

                proveedor.editarProveedor(cod, txtRazonSocial.Text, txtEmail.Text, Convert.ToInt32(txtTelefono.Text), txtDireccion.Text, pEstado);
                dgProveedor.DataSource = proveedor.Listar();
                txtCodProveedor.Enabled = true;
                Limpiar();
                MessageBox.Show("Proveedor actualizado con éxito.", "Proveedor Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
