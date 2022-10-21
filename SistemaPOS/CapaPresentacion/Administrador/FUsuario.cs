
using FontAwesome.Sharp;
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
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion.Administrador
{
    public partial class FUsuario : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form formularioActivo = null;
        public FUsuario()
        {
           //LTUsuario.Text = t_usuario;
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
            txtUsuario.Clear();
            txtContraseña.Clear();
            this.cbRol.SelectedIndex = -1;
            this.cbEstado.SelectedIndex = -1;

        }


        private void BAgregar_Click(object sender, EventArgs e)
        {
            CN_Usuario Usuario = new CN_Usuario();
            if (String.IsNullOrWhiteSpace(txtUsuario.Text) || String.IsNullOrWhiteSpace(txtContraseña.Text))
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
                int dni = Convert.ToInt32(cbDNI.Text);


                if (Usuario.UsuarioExiste(dni))
                {
                    MessageBox.Show("El DNI ingresado ya es usuario del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    CN_Usuario usuario = new CN_Usuario();
                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);
                    usuario.agregarUsuario(Convert.ToInt32(cbDNI.Text), txtUsuario.Text, cbRol.Text, txtContraseña.Text, pEstado);
                    dgUsuario.DataSource = usuario.Listar();
                    Limpiar();
                    MessageBox.Show("Se creó un nuevo usuario.", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
               
        }

         private void FUsuario_Load(object sender, EventArgs e)
        {
            CN_Usuario usuario = new CN_Usuario();
            CN_Empleado empleado = new CN_Empleado();
            dgUsuario.DataSource = usuario.Listar();
            dgEmpleado.DataSource = empleado.Listar();

            dgUsuario.Columns["DNI"].DisplayIndex = 0;
            dgUsuario.Columns["ROL"].DisplayIndex = 1;
            dgUsuario.Columns["USUARIO"].DisplayIndex = 2;
            dgUsuario.Columns["CONTRASEÑA"].DisplayIndex = 3;
            dgUsuario.Columns["ESTADO"].DisplayIndex = 4;
            dgUsuario.Columns["Editar"].DisplayIndex = 5;
            dgUsuario.Columns["Editar"].HeaderText = "EDITAR";
            dgUsuario.Columns["CEstado"].Visible = false;

            List<int> listaDNI = empleado.ListaDNI();
            foreach (var dni in listaDNI)
            {
                cbDNI.Items.Add(dni.ToString());
            }
            this.cbDNI.SelectedIndex = -1;

            List<object> listaRoles = usuario.roles();
            foreach (var rol in listaRoles)
            {
                cbRol.Items.Add(rol.ToString());
            }
            this.cbRol.SelectedIndex = -1;

            cbEstado.Items.Add("Inacctivo");
            cbEstado.Items.Add("Activo");

            this.cbEstado.SelectedIndex = -1;
         }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUsuario.Columns[e.ColumnIndex].Name == "Editar")
            {
                CN_Usuario usuario = new CN_Usuario();
                CN_Rol rol = new CN_Rol();

                int dniUsuario = Convert.ToInt32(dgUsuario.CurrentRow.Cells["DNI"].Value.ToString());
                Usuario usuarioSelect = usuario.UnUsuario(dniUsuario);

                string rolSelect = dgUsuario.CurrentRow.Cells["ROL"].Value.ToString();
                //string estadoSelect = dgUsuario.CurrentRow.Cells["ESTADO"].Value.ToString();

                cbDNI.Text = (usuarioSelect.dni).ToString();
                txtUsuario.Text = usuarioSelect.usuario1;
                cbRol.Text = rolSelect;
                txtContraseña.Text = usuarioSelect.contraseña;
                //cbEstado.Text = usuarioSelect.estado == 1 ? "Activo" : "Inactivo";
                this.cbEstado.SelectedIndex = Convert.ToInt32(usuarioSelect.estado);

                cbDNI.Enabled = false;
                dgUsuario.Columns["CEditar"].Visible = false;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_Usuario usuario = new CN_Usuario();

            if (String.IsNullOrWhiteSpace(cbDNI.Text) || String.IsNullOrWhiteSpace(txtUsuario.Text) || String.IsNullOrWhiteSpace(txtContraseña.Text))
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
                cbDNI.Enabled = true;
            }
            else
            {
                int dni = Convert.ToInt32(cbDNI.Text);
                if (usuario.UsuarioExiste(dni))
                {

                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                    usuario.editarUsuario(Convert.ToInt32(cbDNI.Text), txtUsuario.Text, cbRol.Text, txtContraseña.Text, pEstado);
                    dgUsuario.DataSource = usuario.Listar();
                    cbDNI.Enabled = true;
                    Limpiar();
                    MessageBox.Show("Usuario actualizado con éxito.", "Usuario Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es usuario del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
