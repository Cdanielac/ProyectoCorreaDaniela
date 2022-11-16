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

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
           
            //int valor;
            //valor = Convert.ToInt32(btnCargarReporte.Text); 
            //this.ProductoTableAdapter.ListarRegistros(this.DS_SistemaIAR.Productos,valor);
            //this.rvProductos.RefreshReport();


            //Ds = "DS_SistemaIAR";
            //Reporte = "SistemaPOS.CapaPresentacion.Administrador.Reportes.RProductoPorCategoria.rdlc";

            //CN_Conexion_DS cx = new CN_Conexion_DS();

            //ReportDataSource rd = new ReportDataSource(Ds, cx.QueryConsultaDataSet(Q).Tables[0]);
            //rvProductos.LocalReport.DataSources.Clear();
            //rvProductos.LocalReport.DataSources.Add(rd);
            //rvProductos.LocalReport.ReportEmbeddedResource = Reporte;
            //rvProductos.LocalReport.Refresh();
            //rvProductos.Refresh();
            //rvProductos.RefreshReport();

        }
    }
}
