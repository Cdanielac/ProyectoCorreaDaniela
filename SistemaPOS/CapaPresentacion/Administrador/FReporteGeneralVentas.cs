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
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;


namespace CapaPresentacion.Administrador
{
    public partial class FReporteGeneralVentas : Form
    {

        public FReporteGeneralVentas()
        {
            InitializeComponent();

        }

        private void FReporteGeneralVentas_Load(object sender, EventArgs e)
        {
            //this.ventaCajaTableAdapter.Fill(this.dSVentas.VentaCaja);
            CN_Reportes reportes = new CN_Reportes();

            //Ventas Por cajero
            List<string> listaCajeros = reportes.acumuladoPorCajero();
            List<decimal> listaSubtotal = reportes.acumuladoPorCajeroA();
            chart1.Series[0].Points.DataBindXY(listaCajeros, listaSubtotal);

            //Ventas Por Mes
            List<string> listaMes = reportes.acumuladoPorMes(Convert.ToDateTime("2022/01/01"));
            List<decimal> listaAcumulado = reportes.acumuladoPorMesA(Convert.ToDateTime("2022/01/01"));
            chart2.Series[0].Points.DataBindXY(listaMes, listaAcumulado);

            //Ventas por categoria
            List<string> listaCategoría = reportes.acumuladoPorCategoria();
            List<decimal> listaTotal = reportes.acumuladoPorCategoriaA();
            chart3.Series[0].Points.DataBindXY(listaCategoría, listaTotal);
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            CN_Reportes reportes = new CN_Reportes();
            List<string> listaMes = reportes.acumuladoPorMes(Convert.ToDateTime(dtAño.Text));
            List<decimal> listaAcumulado = reportes.acumuladoPorMesA(Convert.ToDateTime(dtAño.Text));
            chart2.Series[0].Points.DataBindXY(listaMes, listaAcumulado);
        }
    }
}
