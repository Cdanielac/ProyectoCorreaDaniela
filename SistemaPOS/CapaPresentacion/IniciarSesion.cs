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
using CapaPresentacion.Cajero;
using CapaPresentacion.JCI;
using CapaDatos;
using CapaDatos.Entity;

namespace CapaPresentacion
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            this.Show();
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

        private void BIngresar_Click(object sender, EventArgs e)
        {
            CN_Usuario usuario = new CN_Usuario();
            Usuario o_Usuario = usuario.UnUsuario(Convert.ToInt32(txtUsuario.Text));

            if (o_Usuario != null)
            {

                if (o_Usuario.idRol == 1)
                {
                    MenuPrincipal form = new MenuPrincipal(o_Usuario);

                    form.Show();
                    this.Hide();
                    form.FormClosing += Frm_closing;
                }
                else if (o_Usuario.idRol == 2)
                {
                    MenuCajero form = new MenuCajero(o_Usuario);

                    form.Show();
                    this.Hide();
                    form.FormClosing += Frm_closing;
                }
                else
                {
                    MenuJCI form = new MenuJCI(o_Usuario);

                    form.Show();
                    this.Hide();
                    form.FormClosing += Frm_closing;
                }

            }
            else
            {
                MessageBox.Show("No se encontró usuario", "Usuario no válido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
