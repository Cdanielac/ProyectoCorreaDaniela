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

namespace CapaPresentacion
{
    public partial class FClientes : Form
    {
        int idUsuarioActual;
        public FClientes(int pUsuario)
        {
            InitializeComponent();
            idUsuarioActual = pUsuario;
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

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede ingresar letras.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void Limpiar()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();

        }

        private void FClientes_Load(object sender, EventArgs e)
        {
            CN_Cliente cliente = new CN_Cliente();

            dgCliente.DataSource = cliente.Listar();

            dgCliente.Columns["DNI"].DisplayIndex = 0;
            dgCliente.Columns["APELLIDO"].DisplayIndex = 1;
            dgCliente.Columns["NOMBRE"].DisplayIndex = 2;
            dgCliente.Columns["EMAIL"].DisplayIndex = 3;
            dgCliente.Columns["TELEFONO"].DisplayIndex = 4;
            dgCliente.Columns["DIRECCION"].DisplayIndex = 5;
            dgCliente.Columns["ESTADO"].DisplayIndex = 6;
            dgCliente.Columns["Editar"].DisplayIndex = 7;

            cbEstado.Items.Add("Inacctivo");
            cbEstado.Items.Add("Activo");

            this.cbEstado.SelectedIndex = 1;

            if (idUsuarioActual != 1)
            {
                cbEstado.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Cliente cliente = new CN_Cliente();

            if (String.IsNullOrWhiteSpace(txtDNI.Text) || String.IsNullOrWhiteSpace(txtApellido.Text) || String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtDireccion.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text))
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
                int dni = Convert.ToInt32(txtDNI.Text);


                if ((cliente.DniExiste(dni)))
                {
                    MessageBox.Show("El DNI ingresado ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);
                    cliente.agregarCliente(Convert.ToInt32(txtDNI.Text), txtApellido.Text, txtNombre.Text, txtEmail.Text, Convert.ToInt32(txtTelefono.Text), txtDireccion.Text, pEstado);
                    dgCliente.DataSource = cliente.Listar();
                    Limpiar();
                    MessageBox.Show("Nuevo Cliente agregado con éxito.", "Nuevo Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }

        private void dgCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgCliente.Columns[e.ColumnIndex].Name == "Editar")
            {
                CN_Cliente cliente = new CN_Cliente();

                int dniCliente = Convert.ToInt32(dgCliente.CurrentRow.Cells["DNI"].Value.ToString());

                Cliente clienteSelect = cliente.UnCliente(dniCliente);

                txtDNI.Text = (clienteSelect.dni).ToString();
                txtApellido.Text = clienteSelect.apellido;
                txtNombre.Text = clienteSelect.nombre;
                txtEmail.Text = clienteSelect.email;
                txtDireccion.Text = clienteSelect.direccion;
                txtTelefono.Text = (clienteSelect.telefono).ToString();
                cbEstado.Text = clienteSelect.estado == 1 ? "Activo" : "Inactivo";

                txtDNI.Enabled = false;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_Cliente cliente = new CN_Cliente();

            if (String.IsNullOrWhiteSpace(txtDNI.Text) || String.IsNullOrWhiteSpace(txtApellido.Text) || String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtDireccion.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text))
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
                txtDNI.Enabled = true;
            }
            else
            {
                int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                cliente.editarCliente(Convert.ToInt32(txtDNI.Text), txtApellido.Text, txtNombre.Text, txtEmail.Text, Convert.ToInt32(txtTelefono.Text), txtDireccion.Text, pEstado);
                dgCliente.DataSource = cliente.Listar();
                txtDNI.Enabled = true;
                Limpiar();
                MessageBox.Show("Cliente actualizado con éxito.", "Cliente Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
