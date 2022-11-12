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
        public int agregarVenta(string pTipoFactura, int pUsuario, int pCliente, string pFormaPago, decimal pTotal)
        {
            return ventas.agregarVenta(pTipoFactura, pUsuario, pCliente, pFormaPago, pTotal);
        }

        public void detalleVenta(int pIdVenta, int pIdProducto, int pCantidad, decimal pSubtotal)
        {
            ventas.detalleVenta(pIdVenta, pIdProducto, pCantidad, pSubtotal);

        }

        public bool validarStock(int pProducto, int pCantidad)
        {
            return ventas.validarStock(pProducto, pCantidad);
        }
    }
}
