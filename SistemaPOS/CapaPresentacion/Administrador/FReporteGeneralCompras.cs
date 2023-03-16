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
    public partial class FReporteGeneralCompras : Form
    {
        public FReporteGeneralCompras()
        {
            InitializeComponent();
        }

        private void FReporteGeneralCompras_Load(object sender, EventArgs e)
        {
            if (chComprasCategoria.Series["Series1"] != null || chComprasUsuario.Series["Series1"] != null || chGanancias.Series["Series1"] != null)
            {
                chComprasCategoria.Series["Series1"].Points.Clear();
                chComprasUsuario.Series["Series1"].Points.Clear();
                chGanancias.Series["Series1"].Points.Clear();
            }

            int[] serie = new int[10];

            for (int i = 0; i < 10; i++)
            {
                serie[i] = (i + 2);
            }

            foreach (object item in serie)
            {
                chComprasCategoria.Series["Series1"].Points.AddXY(item, item);

            }

            foreach (object item in serie)
            {
                chComprasUsuario.Series["Series1"].Points.AddXY(item, item);

            }

            foreach (object item in serie)
            {
                chGanancias.Series["Series1"].Points.AddXY(item, item);

            }

        }
    }

}
