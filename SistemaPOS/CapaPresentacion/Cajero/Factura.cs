using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Cajero
{
    public partial class Factura : Form
    {
        int nroFactura;
        public Factura(int pNroFactura)
        {
            InitializeComponent();
            nroFactura = pNroFactura;
        }

        private void Factura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.facturaTableAdapter.Fill(this.dB_POSDataSet.Factura, nroFactura);
            this.reportViewer1.RefreshReport();
        }
    }
}
