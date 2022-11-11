using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entity;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Net.Configuration;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int agregarVenta(string pTipoFactura, int pUsuario, int pCliente, string pFormaPago, decimal pTotal, List<DetalleVenta> pDetalle)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Venta nuevaVenta = new Venta();
                DetalleVenta nuevoDetalleVenta = new DetalleVenta();

                TipoFactura tipoFacturaSelect = db.TipoFactura.Where(s => s.descripcion == pTipoFactura).FirstOrDefault();
                FormaPago formaPagoSelect = db.FormaPago.Where(s => s.descripcion == pFormaPago).FirstOrDefault();
                Cliente clienteSelect = db.Cliente.Where(s => s.dni == pCliente).FirstOrDefault();
                Usuario usuarioSelect = db.Usuario.Where(s => s.idUsuario == pUsuario).FirstOrDefault();

                nuevaVenta.idTipoFactura = tipoFacturaSelect.idTipoFactura;
                nuevaVenta.idUsuario = usuarioSelect.idUsuario;
                nuevaVenta.idCliente = clienteSelect.idCliente;
                nuevaVenta.idFormaPago = formaPagoSelect.idFormaPago;
                nuevaVenta.fechaAlta = DateTime.Now;
                nuevaVenta.total = pTotal;
                nuevaVenta.estado = 1;

                db.Venta.Add(nuevaVenta);
                db.SaveChanges();

                List<DetalleVenta> listaDetalle = pDetalle;
                foreach (var detalle in listaDetalle)
                {
                    nuevoDetalleVenta.idVenta = nuevaVenta.idVenta;
                    nuevoDetalleVenta.idProducto = detalle.idProducto;
                    nuevoDetalleVenta.cantidad = detalle.cantidad;
                    nuevoDetalleVenta.subtotal = detalle.subtotal;
                    nuevoDetalleVenta.estado = 1;

                    db.DetalleVenta.Add(nuevoDetalleVenta);
                    db.SaveChanges();
                }
                return nuevaVenta.idVenta;
            }
        }

    }
}

