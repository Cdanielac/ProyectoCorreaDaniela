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
    public partial class FRepVentaRV : Form
    {
        public FRepVentaRV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSVentas.DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.detalleVentaTableAdapter.Fill(this.dSVentas.DetalleVenta);
            // TODO: esta línea de código carga datos en la tabla 'dSVentas.VentaCaja' Puede moverla o quitarla según sea necesario.
            this.ventaCajaTableAdapter.Fill(this.dSVentas.VentaCaja);

            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }
    }
}
