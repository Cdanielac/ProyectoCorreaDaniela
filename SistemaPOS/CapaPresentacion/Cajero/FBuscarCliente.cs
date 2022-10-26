using CapaNegocio;
using CapaPresentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Cajero
{
    public partial class FBuscarCliente : Form
    {
        public FBuscarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = cbFiltro.Text;

            txtFiltro.Focus();
            dgCliente.ClearSelection();

            if (dgCliente.Rows.Count >0)
            {
                foreach (DataGridViewRow row in dgCliente.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtFiltro.Text.Trim().ToUpper()))
                    {
                        row.DefaultCellStyle.BackColor = Color.Thistle;
                        
                        row.Index = 0;
                    
                    }
                    else
                    {
                        //try
                        //{
                        //row.Visible = false;
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

        private void FBuscarCliente_Load(object sender, EventArgs e)
        {
            CN_Cliente cliente = new CN_Cliente();

            dgCliente.DataSource = cliente.ListarConsulta();
            
            txtFiltro.Focus();
            dgCliente.ClearSelection();

            cbFiltro.Items.Add("DNI");
            cbFiltro.Items.Add("APELLIDO");
            cbFiltro.Items.Add("NOMBRE");
            cbFiltro.Items.Add("EMAIL");
            cbFiltro.Items.Add("TELEFONO");
            cbFiltro.Items.Add("ESTADO");

        }

        private void Limpiar()
        {
            CN_Producto producto = new CN_Producto();

            txtFiltro.Clear();
            cbFiltro.SelectedIndex = -1;
            dgCliente.DataSource = producto.ListarConsulta();
           
            dgCliente.ClearSelection();
            txtFiltro.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
            FRegistrarVenta frmRegistrarVenta = Owner as FRegistrarVenta;
            string dni = dgCliente.CurrentRow.Cells["DNI"].Value.ToString();
            string nombYApe = dgCliente.CurrentRow.Cells["APELLIDO"].Value.ToString() + " " + dgCliente.CurrentRow.Cells["NOMBRE"].Value.ToString();

            frmRegistrarVenta.txtDniCliente.Text = dni;
            frmRegistrarVenta.txtCliente.Text = nombYApe;


            this.Close();
        }
    }
}
