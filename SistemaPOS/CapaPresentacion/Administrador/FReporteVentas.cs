
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

namespace CapaPresentacion.Administrador
{
    public partial class FReporteVentas : Form
    {
        Usuario usuarioActual = new Usuario();
        public FReporteVentas(Usuario pUsuario)
        {
            InitializeComponent();
            usuarioActual = pUsuario;
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            FReporteGeneralVentas form = new FReporteGeneralVentas();

            form.Show();
            this.Hide();
            form.FormClosing += Frm_closing;
        }

        private void FReporteVentas_Load(object sender, EventArgs e)
        {
            Usuario user = usuarioActual;
            if (usuarioActual.idRol != 1)
            {
                btnReporteGeneral.Enabled = false;
            }
        }
    }
}
