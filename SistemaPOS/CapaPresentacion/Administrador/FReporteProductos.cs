using CapaDatos.Entity;
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

namespace CapaPresentacion.Administrador
{
    public partial class FReporteProductos : Form
    {
        public FReporteProductos()
        {
            InitializeComponent();
        }

        private void FReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSProductos.VentasCategoria' Puede moverla o quitarla según sea necesario.
            this.ventasCategoriaTableAdapter.Fill(this.dSProductos.VentasCategoria);
            CN_Categoria categoria = new CN_Categoria();
            List<Categoria> listaCategoria = categoria.ListaCategoria();
            foreach (var o_Categoria in listaCategoria)
            {
                cbCategoria.Items.Add(o_Categoria.descripcion.ToString());
            }
            this.cbCategoria.SelectedIndex = -1;
            this.reportViewer1.RefreshReport();

           // this.ventasCategoriaTableAdapter.Fill(this.dSProductos.VentasCategoria);
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Categoria categoria = new CN_Categoria();

            Categoria categoriaSelect = categoria.UnaCategoriaDesc(cbCategoria.Text);
            this.reportViewer1.RefreshReport();
            this.productoCategoriaTableAdapter.Fill(this.dSProductos.ProductoCategoria, categoriaSelect.idCategoria);
            this.reportViewer1.RefreshReport();
        }
    }
}
