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
using System.Windows.Media.Imaging;

namespace CapaPresentacion.Administrador
{
    public partial class FReporteUsuarios : Form
    {
        Bitmap bmp;
        public FReporteUsuarios()
        {
            InitializeComponent();
        }

        private void FReporteUsuarios_Load(object sender, EventArgs e)
        {
            //chart1.DataSource = dB_POSDataSet.RolUsuario;
            //chart1.Series["Series1"].XValueMember = "Rol";
            //chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            //chart1.Series["Series1"].YValueMembers = "Cantidad";
            //chart1.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            CN_Reportes reportes = new CN_Reportes();   
            //Empleados más antiguos
            List<string> listaEmpleados = reportes.EmpleadoAntiguedad();
            List<int> listaAntiguedad = reportes.EmpleadoAntiguedadA();
            chart1.Series[0].Points.DataBindXY(listaEmpleados, listaAntiguedad);

            //Usuarios por Rol
            List<string> listaUsuarios = reportes.UsuarioRol();
            List<int> listacantidad = reportes.UsuarioRolC();
            chart2.Series[0].Points.DataBindXY(listaUsuarios, listacantidad);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp,0,0);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0,0, this.Size);
            //printPreviewDialog1.ShowDialog();
        }
    }
}
