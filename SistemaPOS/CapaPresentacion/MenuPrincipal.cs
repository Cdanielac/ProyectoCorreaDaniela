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
using CapaPresentacion.JCI;
using CapaDatos.Entity;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form formularioActivo = null;
        public MenuPrincipal(Usuario o_usuario)
        {
            usuarioActual = o_usuario;
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           Usuario user = usuarioActual;
            
           LUser.Text = user.usuario1.ToString();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Thistle;
            }
            menu.BackColor = Color.Silver;
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
        private void MUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FUsuario());
        }

        private void MEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmEmpleados());
        }

        private void MOCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MMantenedor, new frmCategoria());
        }

        private void MOProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MMantenedor, new frmProducto(usuarioActual.idRol));
        }

        private void MOVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MReportes, new FReporteVentas(usuarioActual));
        }

        private void MOCompras_Click(object sender, EventArgs e)
        {
           // AbrirFormulario((IconMenuItem)MReportes, new FReporteProductos());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAcercaDe());
        }

        private void MOBackUp_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FBackUp());
        }

    }
}
