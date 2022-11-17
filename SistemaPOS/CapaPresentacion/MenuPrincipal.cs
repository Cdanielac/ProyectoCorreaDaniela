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
using CapaPresentacion.Cajero;

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
            try
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
                try
                {
                    formulario.Show();
                }
                catch(System.InvalidOperationException)
                {
                    MessageBox.Show("Espere un momento y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
            }
            catch
            {
                MessageBox.Show("Espere un momento y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void MUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FUsuario());
        }

        private void MEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmEmpleados());
        }

        private void MOVentas_Click(object sender, EventArgs e)
        {
            //FReporteVentas frm = new FReporteVentas(usuarioActual);
            //frm.Show();
            AbrirFormulario((IconMenuItem)MReportes, new FReporteVentas(usuarioActual));
        }

        private void MOReportProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MReportes, new FReporteProductos());
        }

        private void MOClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MAdmin, new FClientes(usuarioActual));
        }

        private void MOProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MAdmin, new frmProveedores(usuarioActual));
        }

        private void MAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAcercaDe());
        }

        private void MOBackUp_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FBackUp());
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

        private void MClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MAdmin, new FClientes(usuarioActual));
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)MAdmin, new frmProducto(usuarioActual));
        }
    }
}
