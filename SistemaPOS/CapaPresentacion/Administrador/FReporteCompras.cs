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
using System.Windows.Media.Media3D;

namespace CapaPresentacion.Administrador
{
    public partial class FReporteCompras : Form
    {
        Usuario usuarioActual = new Usuario();
        public FReporteCompras(Usuario pUsuario)
        {
            usuarioActual = pUsuario;
            InitializeComponent();
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            FReporteGeneralCompras form = new FReporteGeneralCompras();

            form.Show();
            this.Hide();
            form.FormClosing += Frm_closing;
        }

        private void FReporteCompras_Load(object sender, EventArgs e)
        {
            Usuario user = usuarioActual;
            if (usuarioActual.idRol != 1)
            {
                btnReporteGeneral.Enabled = false;
            }

            CN_Compra compra = new CN_Compra();

            dgCompras.DataSource = compra.ListarCompra();

            //dgCompras.Columns["NROCOMPRA"].DisplayIndex = 0;
            //dgCompras.Columns["TIPOFACTURA"].DisplayIndex = 1;
            //dgCompras.Columns["USUARIO"].DisplayIndex = 2;
            //dgCompras.Columns["PROVEEDOR"].DisplayIndex = 3;
            //dgCompras.Columns["TOTAL"].DisplayIndex = 3;
            //dgCompras.Columns["VerDetalle"].DisplayIndex = 4;


            List<Compra> listaCompra = compra.ListaCompra();
            foreach (var comp in listaCompra)
            {
                cbNroCompra.Items.Add(comp.idCompra.ToString());
            }
            //this.cbNroCompra.SelectedIndex = 0;

        }

        private void dgCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCompras.Columns[e.ColumnIndex].Name == "VerDetalle")
            {

                CN_Compra detalleCompra = new CN_Compra();
                dgDetalleCompra.DataSource = detalleCompra.ListarDetalleCompra();


            }
        }
    }
}
