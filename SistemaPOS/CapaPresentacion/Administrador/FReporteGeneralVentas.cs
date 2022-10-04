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
    public partial class FReporteGeneralVentas : Form
    {
        public FReporteGeneralVentas()
        {
            InitializeComponent();
        }

        private void FReporteGeneralVentas_Load(object sender, EventArgs e)
        {
                    
            if (chVentasCategoria.Series["Series1"] != null || chVentasUsuario.Series["Series1"] != null || chGanancias.Series["Series1"] != null)
            {
                chVentasCategoria.Series["Series1"].Points.Clear();
                chVentasUsuario.Series["Series1"].Points.Clear();
                chGanancias.Series["Series1"].Points.Clear();
            }

            int[] serie = new int[10];

            for (int i = 0; i < 10; i++)
            {
                serie[i] = (i+2);
            }

            foreach (object item in serie)
            {
                chVentasCategoria.Series["Series1"].Points.AddXY(item, item);
                
            }

            foreach (object item in serie)
            {
                chVentasUsuario.Series["Series1"].Points.AddXY(item, item);

            }

            foreach (object item in serie)
            {
                chGanancias.Series["Series1"].Points.AddXY(item, item);

            }

        }
    }
}
