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
        public int agregarVenta(string pTipoFactura, int pUsuario, int pCliente, string pFormaPago, decimal pTotal, List<DetalleVenta> pDetalle)
        {
            return ventas.agregarVenta(pTipoFactura, pUsuario, pCliente, pFormaPago, pTotal, pDetalle);
        }


    }
}
