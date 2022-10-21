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

        }


        private void BAgregar_Click(object sender, EventArgs e)
        {
            CN_Empleado empleado = new CN_Empleado();

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


                if ((empleado.DniExiste(dni))){
                    MessageBox.Show("El DNI ingresado ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FEmpleados_Load(object sender, EventArgs e)
        {
            CN_Empleado empleado = new CN_Empleado();
           
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


            cbEstado.Items.Add("Inacctivo");
            cbEstado.Items.Add("Activo");
            
            this.cbEstado.SelectedIndex = 1;
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
                cbEstado.Text = empledoSelect.estado == 1?  "Activo" : "Inactivo";

                txtDNI.Enabled = false;

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
                txtDNI.Enabled = true;
            }
            else
            {
                int pEstado = Convert.ToInt32(cbEstado.Text == "Activo" ? 1 : 0);

                empleado.editarEmpleado(Convert.ToInt32(txtDNI.Text), txtApellido.Text, txtNombre.Text, txtEmail.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text), pEstado);
                dgEmpleados.DataSource = empleado.Listar();
                txtDNI.Enabled = true;
                Limpiar();
                MessageBox.Show("Empleado actualizado con éxito.", "Empleado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
