using CapaDatos;
using CapaDatos.Entity;
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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
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
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            cbEstado.SelectedIndex = -1;
            txtDNI.Focus();
            txtDNI.Enabled = true;
            txtEmail.Enabled = true;

        }


        private void BAgregar_Click(object sender, EventArgs e)
        {
            CN_Empleado empleado = new CN_Empleado();

            if (String.IsNullOrWhiteSpace(txtDNI.Text) || String.IsNullOrWhiteSpace(txtApellido.Text) || String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtDireccion.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long dni = long.Parse(txtDNI.Text);
            string dni1 = dni.ToString();
            if (dni1.Length > 8 || dni1.Length < 8)
            {
                MessageBox.Show("El DNI debe contener 8 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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


                    if ((empleado.DniExiste(dni)))
                    {
                        MessageBox.Show("El DNI ingresado ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string email = txtEmail.Text;
                        if (empleado.EmailExiste(email))
                        {
                            MessageBox.Show("El email ingresado pertenece a otro empleado, por favor ingrese otro email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);
                            empleado.agregarEmpleado(Convert.ToInt32(txtDNI.Text), txtApellido.Text, txtNombre.Text, txtEmail.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text), pEstado);
                            dgEmpleados.DataSource = empleado.Listar();
                            Limpiar();
                            MessageBox.Show("Nuevo Empleado agregado con éxito.", "Nuevo Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                }
            }

            
        }

        private void FEmpleados_Load(object sender, EventArgs e)
        {
            CN_Empleado empleado = new CN_Empleado();

            txtDNI.Focus();

            dgEmpleados.DataSource = empleado.Listar();

            dgEmpleados.Columns["DNI"].DisplayIndex = 0;
            dgEmpleados.Columns["APELLIDO"].DisplayIndex = 1;
            dgEmpleados.Columns["NOMBRE"].DisplayIndex = 2;
            dgEmpleados.Columns["EMAIL"].DisplayIndex = 3;
            dgEmpleados.Columns["DIRECCION"].DisplayIndex = 4;
            dgEmpleados.Columns["TELEFONO"].DisplayIndex = 5;
            dgEmpleados.Columns["ESTADO"].DisplayIndex = 6;
            dgEmpleados.Columns["Editar"].DisplayIndex = 7;
            dgEmpleados.Columns["Editar"].HeaderText= "EDITAR";

            Editar.Text = "EDITAR";
            Editar.UseColumnTextForButtonValue = true;


            cbEstado.Items.Add("Inactivo");
            cbEstado.Items.Add("Activo");
            
            this.cbEstado.SelectedIndex = -1;

            dgEmpleados.ClearSelection();

            cbFiltro.Items.Add("DNI");
            cbFiltro.Items.Add("APELLIDO");
            cbFiltro.Items.Add("NOMBRE");
            cbFiltro.Items.Add("EMAIL");
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                CN_Empleado empleado = new CN_Empleado();
                
                int dniEmpleado = Convert.ToInt32(dgEmpleados.CurrentRow.Cells["DNI"].Value.ToString());

                Empleado empledoSelect = empleado.UnEmpleado(dniEmpleado);

                txtDNI.Text = (empledoSelect.dni).ToString();
                txtApellido.Text = empledoSelect.apellido;
                txtNombre.Text = empledoSelect.nombre;
                txtEmail.Text = empledoSelect.email;
                txtDireccion.Text = empledoSelect.direccion;
                txtTelefono.Text = (empledoSelect.telefono).ToString();
                this.cbEstado.SelectedIndex = Convert.ToInt32(empledoSelect.estado);

                txtDNI.Enabled = false;
                txtEmail.Enabled = false;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_Empleado empleado = new CN_Empleado();

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
            }
            else
            {
                long dniExiste = long.Parse(txtDNI.Text);
                if (empleado.DniExiste(dniExiste))
                {
                    int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                    empleado.editarEmpleado(Convert.ToInt32(txtDNI.Text), txtApellido.Text, txtNombre.Text, txtEmail.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text), pEstado);
                    dgEmpleados.DataSource = empleado.Listar();
                    Limpiar();
                    MessageBox.Show("Empleado actualizado con éxito.", "Empleado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no pertenece a un Empleado de nuestro sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                
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
            dgEmpleados.ClearSelection();

            if (dgEmpleados.Rows.Count > 0)
            {
                if (String.IsNullOrWhiteSpace(txtFiltro.Text) || String.IsNullOrWhiteSpace(cbFiltro.Text))
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dgEmpleados.Rows)
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
                                this.dgEmpleados.CurrentCell = null;
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

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            CN_Empleado empleados = new CN_Empleado();

            txtFiltro.Focus();
            txtFiltro.Clear();
            cbFiltro.SelectedIndex = -1;
            dgEmpleados.DataSource = empleados.Listar();
            dgEmpleados.ClearSelection();
        }
    }
}
