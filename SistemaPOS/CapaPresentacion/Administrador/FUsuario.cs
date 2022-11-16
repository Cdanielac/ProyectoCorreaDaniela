
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
using CapaPresentacion.Cajero;

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
            txtDNIUser.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            this.cbRol.SelectedIndex = -1;
            this.cbEstado.SelectedIndex = -1;
            btnBuscarNombre.Focus();
            txtDNIUser.Enabled = true;
        }


        private void BAgregar_Click(object sender, EventArgs e)
        {
            CN_Usuario Usuario = new CN_Usuario();
            if (String.IsNullOrWhiteSpace(txtUsuario.Text) || String.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long dni = long.Parse(txtDNIUser.Text);
            string dni1 = dni.ToString();

            string mensaje = "Los datos serán guardados. ¿Está seguro?";
            string titulo = "Mensaje";
            var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.No)
            {
                Limpiar();
            }
            else
            {


                if (Usuario.UsuarioExiste(dni))
                {
                    MessageBox.Show("El DNI ingresado ya es usuario del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    CN_Usuario usuario = new CN_Usuario();
                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);
                    usuario.agregarUsuario(Convert.ToInt32(txtDNIUser.Text), txtUsuario.Text, cbRol.Text, txtContraseña.Text, pEstado);
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

            dgUsuario.Columns["DNI"].DisplayIndex = 0;
            dgUsuario.Columns["ROL"].DisplayIndex = 1;
            dgUsuario.Columns["USUARIO"].DisplayIndex = 2;
            dgUsuario.Columns["CONTRASEÑA"].DisplayIndex = 3;
            dgUsuario.Columns["ESTADO"].DisplayIndex = 4;
            dgUsuario.Columns["Editar"].DisplayIndex = 5;
            dgUsuario.Columns["Editar"].HeaderText = "EDITAR";
            dgUsuario.Columns["CEstado"].Visible = false;

            Editar.Text = "EDITAR";
            Editar.UseColumnTextForButtonValue = true;


            List<object> listaRoles = usuario.roles();
            foreach (var rol in listaRoles)
            {
                cbRol.Items.Add(rol.ToString());
            }
            this.cbRol.SelectedIndex = -1;

            cbEstado.Items.Add("Inacctivo");
            cbEstado.Items.Add("Activo");

            this.cbEstado.SelectedIndex = -1;

            txtFiltro.Focus();
            dgUsuario.ClearSelection();

            cbFiltro.Items.Add("DNI");
            cbFiltro.Items.Add("ROL");
            cbFiltro.Items.Add("USUARIO");
            cbFiltro.Items.Add("ESTADO");

            btnOcultar_Click(sender, e);
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUsuario.Columns[e.ColumnIndex].Name == "Editar")
            {
                CN_Usuario usuario = new CN_Usuario();
                CN_Rol rol = new CN_Rol();

                long dniUsuario = long.Parse(dgUsuario.CurrentRow.Cells["DNI"].Value.ToString());
                Usuario usuarioSelect = usuario.UnUsuario(dniUsuario);

                string rolSelect = dgUsuario.CurrentRow.Cells["ROL"].Value.ToString();
                //string estadoSelect = dgUsuario.CurrentRow.Cells["ESTADO"].Value.ToString();

                txtDNIUser.Text = (usuarioSelect.dni).ToString();
                txtUsuario.Text = usuarioSelect.usuario1;
                cbRol.Text = rolSelect;
                txtContraseña.Text = usuarioSelect.contraseña;
                //cbEstado.Text = usuarioSelect.estado == 1 ? "Activo" : "Inactivo";
                this.cbEstado.SelectedIndex = Convert.ToInt32(usuarioSelect.estado);

                txtDNIUser.Enabled = false;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_Usuario usuario = new CN_Usuario();

            if (String.IsNullOrWhiteSpace(txtDNIUser.Text) || String.IsNullOrWhiteSpace(txtUsuario.Text) || String.IsNullOrWhiteSpace(txtContraseña.Text))
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
                txtDNIUser.Enabled = true;
            }
            else
            {
                int dni = Convert.ToInt32(txtDNIUser.Text);
                if (usuario.UsuarioExiste(dni))
                {

                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                    usuario.editarUsuario(Convert.ToInt32(txtDNIUser.Text), txtUsuario.Text, cbRol.Text, txtContraseña.Text, pEstado);
                    dgUsuario.DataSource = usuario.Listar();
                    txtDNIUser.Enabled = true;
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            btnMostrar.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            FConsultarEmpleado form = new FConsultarEmpleado();
            AddOwnedForm(form);

            form.Show();
            this.Hide();
            form.FormClosing += Frm_closing;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = cbFiltro.Text;

            txtFiltro.Focus();
            dgUsuario.ClearSelection();

            if (dgUsuario.Rows.Count > 0)
            {
                if (String.IsNullOrWhiteSpace(txtFiltro.Text) || String.IsNullOrWhiteSpace(cbFiltro.Text))
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dgUsuario.Rows)
                    {
                        if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtFiltro.Text.Trim().ToUpper()))
                        {
                            row.Visible = true;
                            row.DefaultCellStyle.BackColor = Color.Thistle;




                        }
                        else
                        {
                            //try
                            //{
                            this.dgUsuario.CurrentCell = null;
                            row.Visible = false;
                            //MessageBox.Show("No exite estock disponible para el producto seleccionado.", "Stock No disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //return;
                            //}
                            //catch(System.InvalidOperationException)
                            //{

                            //}
                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CN_Usuario usuario = new CN_Usuario();

            txtFiltro.Clear();
            cbFiltro.SelectedIndex = -1;
            dgUsuario.DataSource = usuario.Listar();

            dgUsuario.ClearSelection();
            txtFiltro.Focus();
        }
    }
}
