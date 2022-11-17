using CapaDatos.Entity;
using CapaNegocio;
using System;
using System.Collections;
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
    public partial class ReporteProductosVendidos : Form
    {
        public ReporteProductosVendidos()
        {
            InitializeComponent();
        }

        private void ReporteProductosVendidos_Load(object sender, EventArgs e)
        {
            CN_Reportes reportes = new CN_Reportes();

            cbMes.Items.Add("Enero");
            cbMes.Items.Add("Febrero");
            cbMes.Items.Add("Marzo");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Mayo");
            cbMes.Items.Add("Junio");
            cbMes.Items.Add("Julio");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Septiembre");
            cbMes.Items.Add("Octubre");
            cbMes.Items.Add("Noviembre");
            cbMes.Items.Add("Diciembre");

            //Productos más vendidos
            List<string> listaProductos = reportes.productosMasVendidos(11);
            List<int> listaCantidad = reportes.productosMasVendidosC(11);
            chart1.Series[0].Points.DataBindXY(listaProductos, listaCantidad);

            //Ventas Por Mes
            List<string> listaProductos1 = reportes.stockMinimo();
            List<int> listaStock = reportes.stockMinimoS();
            chart2.Series[0].Points.DataBindXY(listaProductos1, listaStock);
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(cbMes.SelectedIndex) + 1) >= 1 && (Convert.ToInt32(cbMes.SelectedIndex) + 1) <= 12)
            {
                CN_Reportes reportes = new CN_Reportes();
                List<string> listaProductos = reportes.productosMasVendidos((Convert.ToInt32(cbMes.SelectedIndex) + 1));
                List<int> listaCantidad = reportes.productosMasVendidosC((Convert.ToInt32(cbMes.SelectedIndex) + 1));
                chart1.Series[0].Points.DataBindXY(listaProductos, listaCantidad);
            }
        }
    }
}
