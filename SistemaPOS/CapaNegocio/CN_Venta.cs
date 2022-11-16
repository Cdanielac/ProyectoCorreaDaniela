using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Entity;

namespace CapaNegocio
{
    public class CN_Venta
    {
        CD_Venta ventas = new CD_Venta();
        public int agregarVenta(string pTipoFactura, int pUsuario, long pCliente, string pFormaPago, decimal pTotal, DateTime pfecha)
        {
            return ventas.agregarVenta(pTipoFactura, pUsuario, pCliente, pFormaPago, pTotal, pfecha);
        }

        public void detalleVenta(int pIdVenta, int pIdProducto, int pCantidad, decimal pSubtotal)
        {
            ventas.detalleVenta(pIdVenta, pIdProducto, pCantidad, pSubtotal);

        }

        public bool validarStock(int pProducto, int pCantidad)
        {
            return ventas.validarStock(pProducto, pCantidad);
        }


        public List<Object> Listar()
        {
            return ventas.Listar();
        }

        public List<Object> ListarC(int pIdUsuario)
        {
            return ventas.ListarC(pIdUsuario);

        }

        public List<Object> ListarFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            return ventas.ListarFecha(fechaInicio, fechaFinal);

        }

        public List<Venta> ListaVenta()
        {
            return ventas.ListaVenta();


        }

        public Venta UnaVenta(int pIdVenta)
        {
            return ventas.UnaVenta(pIdVenta);

        }

        public Boolean VentaExiste(int pIdVenta)
        {
            return ventas.VentaExiste(pIdVenta);

        }

        public List<TipoFactura> ListaTF()
        {
            return ventas.ListaTF();

        }

        public Boolean TipoFacturaExiste(string pTipoFactura)
        {
            return ventas.TipoFacturaExiste(pTipoFactura);

        }

        public List<FormaPago> ListaFP()
        {

            return ventas.ListaFP();


        }

        public Boolean FormaPagoExiste(string pFormaPago)
        {
            return ventas.FormaPagoExiste(pFormaPago);

        }
    }
}