
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Administrador;
using FontAwesome.Sharp;
using CapaDatos.Entity;

namespace CapaPresentacion.JCI
{
    public partial class MenuJCI : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form formularioActivo = null;
        public MenuJCI(Usuario o_usuario)
        {
            usuarioActual = o_usuario;
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LUser.Text = usuarioActual.usuario1;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Thistle;
                MenuActivo.IconColor = Color.White;
                MenuActivo.ForeColor = Color.White;
            }
            menu.BackColor = Color.White;
            menu.IconColor = Color.Thistle;
            menu.ForeColor = Color.Thistle;
            MenuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Thistle;
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MOCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MMantenedor, new frmCategoria());
        }

        private void MOProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MMantenedor, new frmProducto(Convert.ToInt32(usuarioActual.idRol)));
        }

        private void MProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores(Convert.ToInt32(usuarioActual.idRol)));
        }

        private void MAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAcercaDe());
        }

        private void MFacturasCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro?";
            string titulo = "Mensaje";
            var opcion = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
