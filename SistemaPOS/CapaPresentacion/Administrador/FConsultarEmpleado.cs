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
    public partial class FConsultarEmpleado : Form
    {
        public FConsultarEmpleado()
        {
            InitializeComponent();
        }

        private void FConsultarEmpleado_Load(object sender, EventArgs e)
        {
            CN_Empleado empleados = new CN_Empleado();

            dgEmpleados.DataSource = empleados.ListarConsulta();

            txtFiltro.Focus();
            dgEmpleados.ClearSelection();

            cbFiltro.Items.Add("DNI");
            cbFiltro.Items.Add("APELLIDO");
            cbFiltro.Items.Add("NOMBRE");
            cbFiltro.Items.Add("EMAIL");
        }

        private void Limpiar()
        {
            CN_Empleado empleados = new CN_Empleado();

            txtFiltro.Focus();
            txtFiltro.Clear();
            cbFiltro.SelectedIndex = -1;
            dgEmpleados.DataSource = empleados.ListarConsulta();
            dgEmpleados.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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

        private void btbAceptar_Click(object sender, EventArgs e)
        {
            FUsuario frmUsuario = Owner as FUsuario;
            string DNIEmpleado = dgEmpleados.CurrentRow.Cells["DNI"].Value.ToString();

            frmUsuario.txtDNIUser.Text = DNIEmpleado;

            this.Close();
        }
    }
}
