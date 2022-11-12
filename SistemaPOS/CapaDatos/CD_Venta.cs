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
using System.Security.Cryptography.X509Certificates;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int agregarVenta(string pTipoFactura, int pUsuario, int pCliente, string pFormaPago, decimal pTotal)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                    Venta nuevaVenta = new Venta();


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

                    return nuevaVenta.idVenta;
                
            }

      
        }

        public void detalleVenta(int pIdVenta, int pIdProducto, int pCantidad, decimal pSubtotal)
        {
            DetalleVenta nuevoDetalleVenta = new DetalleVenta();

            using (DB_POSEntities db = new DB_POSEntities())
            {
                Producto productoSelect = db.Producto.Where(s => s.idProducto == pIdProducto).First();
                productoSelect.stock = productoSelect.stock - pCantidad;

                db.Producto.Attach(productoSelect); 
                db.Entry(productoSelect).Property(x => x.stock).IsModified = true; 
                db.SaveChanges();

                nuevoDetalleVenta.idVenta = pIdVenta;
                nuevoDetalleVenta.idProducto = pIdProducto;
                nuevoDetalleVenta.cantidad = pCantidad;
                nuevoDetalleVenta.subtotal = pSubtotal;
                nuevoDetalleVenta.estado = 1;

                db.DetalleVenta.Add(nuevoDetalleVenta);
                db.SaveChanges();

            }

        }

        public bool validarStock(int pProducto, int pCantidad)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Producto productoSelect = db.Producto.Where(s => s.idProducto == pProducto).First();
                return productoSelect.stock >= pCantidad;
            }
        }

    }
}

