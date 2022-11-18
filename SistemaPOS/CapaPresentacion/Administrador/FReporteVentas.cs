
using CapaDatos;
using CapaDatos.Entity;
using CapaNegocio;
using CapaPresentacion.Cajero;
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
    public partial class FReporteVentas : Form
    {
        Usuario usuarioActual = new Usuario();
        public FReporteVentas(Usuario pUsuario)
        {
            InitializeComponent();
            usuarioActual = pUsuario;
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            FReporteGeneralVentas form = new FReporteGeneralVentas();

            form.Show();
            this.Hide();
            form.FormClosing += Frm_closing;
        }

        private void FReporteVentas_Load(object sender, EventArgs e)
        {
            CN_Venta ventas = new CN_Venta();
            CN_Reportes reportes = new CN_Reportes();
            if (usuarioActual.idRol != 1)
            {
                btnReporteGeneral.Enabled = false;
                dgVentas.DataSource = ventas.ListarC(usuarioActual.idUsuario);
                cbFiltro.Items.Add("NroVenta");
                cbFiltro.Items.Add("Cliente");
                cbFiltro.Items.Add("TipoFactura");
                cbFiltro.Items.Add("FormaPago");

                List<int> listaProductos = reportes.ventasPorFechaCajeroV(Convert.ToDateTime("2010/01/01"), DateTime.Now, usuarioActual.idUsuario);
                List<decimal> listaSubtotal = reportes.ventasPorFechaCajeroT(Convert.ToDateTime("2010/01/01"), DateTime.Now,usuarioActual.idUsuario);

                chart1.Series[0].Points.DataBindXY(listaProductos, listaSubtotal);
            }
            else
            {
                dgVentas.DataSource = ventas.Listar();
                cbFiltro.Items.Add("NroVenta");
                cbFiltro.Items.Add("Cajero");
                cbFiltro.Items.Add("Cliente");
                cbFiltro.Items.Add("TipoFactura");
                cbFiltro.Items.Add("FormaPago");


                List<int> listaProductos = reportes.ventasPorFechaP(Convert.ToDateTime("2010/01/01"), DateTime.Now);
                List<decimal> listaSubtotal = reportes.ventasPorFechaS(Convert.ToDateTime("2010/01/01"), DateTime.Now);

                chart1.Series[0].Points.DataBindXY(listaProductos, listaSubtotal);
            }


            this.cbFiltro.SelectedIndex = -1;

            cbFiltro.Focus();

            

            dgVentas.Columns["NroVenta"].DisplayIndex = 0;
            dgVentas.Columns["Fecha"].DisplayIndex = 1;
            dgVentas.Columns["Cajero"].DisplayIndex = 2;
            dgVentas.Columns["Cliente"].DisplayIndex = 3;
            dgVentas.Columns["TipoFactura"].DisplayIndex = 4;
            dgVentas.Columns["FormaPago"].DisplayIndex = 5;
            dgVentas.Columns["Total"].DisplayIndex = 6;
            dgVentas.Columns["Estado"].DisplayIndex = 7;
            dgVentas.Columns["CVerDetalle"].DisplayIndex = 8;

            dgVentas.Columns["CVerDetalle"].HeaderText = "VER DETALLE";
            dgVentas.Columns["TipoFactura"].HeaderText = "Tipo de Factura";
            dgVentas.Columns["FormaPago"].HeaderText = "Forma de Pago";
            CVerDetalle.Text = "VER DETALLE";
            CVerDetalle.UseColumnTextForButtonValue = true;

        }

        public void Limpiar()
        {

            CN_Venta ventas = new CN_Venta();
            cbFiltro.SelectedIndex = -1;
            if (usuarioActual.idRol != 1)
            {
                dgVentas.DataSource = ventas.ListarC(usuarioActual.idUsuario);

            }
            else
            {
                dgVentas.DataSource = ventas.Listar();

            }

        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            CN_Venta ventas = new CN_Venta();
            CN_Reportes reportes = new CN_Reportes();

            dgVentas.DataSource = ventas.ListarFecha(Convert.ToDateTime(dtFechaDesde.Text), Convert.ToDateTime(dtFechaHasta.Text), usuarioActual);

            if (usuarioActual.idRol == 1)
            {
                

                List<int> listaProductos = reportes.ventasPorFechaP(Convert.ToDateTime(dtFechaDesde.Text), Convert.ToDateTime(dtFechaHasta.Text));
                List<decimal> listaSubtotal = reportes.ventasPorFechaS(Convert.ToDateTime(dtFechaDesde.Text), Convert.ToDateTime(dtFechaHasta.Text)); ;

                chart1.Series[0].Points.DataBindXY(listaProductos, listaSubtotal);
            }
            else
            {
                List<int> listaProductos = reportes.ventasPorFechaCajeroV(Convert.ToDateTime(dtFechaDesde.Text), Convert.ToDateTime(dtFechaHasta.Text), usuarioActual.idUsuario);
                List<decimal> listaSubtotal = reportes.ventasPorFechaCajeroT(Convert.ToDateTime(dtFechaDesde.Text), Convert.ToDateTime(dtFechaHasta.Text), usuarioActual.idUsuario);

                chart1.Series[0].Points.DataBindXY(listaProductos, listaSubtotal);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CN_Venta ventas = new CN_Venta();
            //dgVentas.DataSource = ventas.UnaVenta(Convert.ToInt32(cbNroVenta.Text));
            string columnaFiltro = cbFiltro.Text;
            dgVentas.ClearSelection();

            if (dgVentas.Rows.Count > 0)
            {
                if (String.IsNullOrWhiteSpace(cbFiltro.Text) || String.IsNullOrWhiteSpace(txtFiltro.Text))
                {
                    MessageBox.Show("Debe completar el campo solicitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                   
                    foreach (DataGridViewRow row in dgVentas.Rows)
                    {
                        if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtFiltro.Text.Trim().ToUpper()))
                        {
                            row.Visible = true;
                            row.DefaultCellStyle.BackColor = Color.Thistle;
                        }
                        else
                        {
                            try
                            {
                                this.dgVentas.CurrentCell = null;
                                row.Visible = false;
                            }
                            catch (System.InvalidOperationException)
                            {

                            }
                        }

                    }
                }
            }
        }

        private void btnListaVenta_Click(object sender, EventArgs e)
        {
            CN_Venta ventas = new CN_Venta();

            Limpiar();

            CN_Reportes reportes = new CN_Reportes();

            if (usuarioActual.idRol == 1)
            {
                List<int> listaProductos = reportes.ventasPorFechaP(Convert.ToDateTime("2010/01/01"), DateTime.Now);
                List<decimal> listaSubtotal = reportes.ventasPorFechaS(Convert.ToDateTime("2010/01/01"), DateTime.Now);

                chart1.Series[0].Points.DataBindXY(listaProductos, listaSubtotal);
            }
            else
            {
                List<int> listaProductos = reportes.ventasPorFechaCajeroV(Convert.ToDateTime("2010/01/01"), DateTime.Now, usuarioActual.idUsuario);
                List<decimal> listaSubtotal = reportes.ventasPorFechaCajeroT(Convert.ToDateTime("2010/01/01"), DateTime.Now, usuarioActual.idUsuario);

                chart1.Series[0].Points.DataBindXY(listaProductos, listaSubtotal);
            }

        }

        private void dgVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVentas.Columns[e.ColumnIndex].Name == "CVerDetalle")
            {
                int nroVenta = Convert.ToInt32(dgVentas.CurrentRow.Cells["NroVenta"].Value.ToString());
                Factura form = new Factura(nroVenta);

                form.Show();
                this.Hide();
                form.FormClosing += Frm_closing;
                Limpiar();

            }
        }
    }
}
