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
        public int agregarVenta(string pTipoFactura, int pUsuario, long pCliente, string pFormaPago, decimal pTotal, DateTime pfecha)
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
                    nuevaVenta.fechaAlta = pfecha;
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


        public List<Object> Listar()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oventas = from Venta in db.Venta.Include("Usuario, TipoFactura, FormaPago, Cliente, Empleado")
                                              select new
                                              {
                                                  NroVenta = Venta.idVenta,
                                                  Fecha = Venta.fechaAlta,
                                                  Cajero = Venta.Usuario.Empleado.apellido + " " + Venta.Usuario.Empleado.nombre,
                                                  Cliente = Venta.Cliente.apellido + " " + Venta.Cliente.nombre,
                                                  TipoFactura = Venta.TipoFactura.descripcion,
                                                  FormaPago = Venta.FormaPago.descripcion,
                                                  Total = Venta.total,
                                                  Estado = (Venta.estado == 1 ? "Activo" : "Inactivo")

                                              };
                return oventas.ToList();
            }


        }

        public List<Object> ListarC(int pIdUsuario)
        {

            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oventas = from Venta in db.Venta.Include("Usuario, TipoFactura, FormaPago, Cliente, Empleado")
                                             where Venta.idUsuario == pIdUsuario
                                             select new
                                             {
                                                 NroVenta = Venta.idVenta,
                                                 Fecha = Venta.fechaAlta,
                                                 Cajero = Venta.Usuario.Empleado.apellido + " " + Venta.Usuario.Empleado.nombre,
                                                 Cliente = Venta.Cliente.apellido + " " + Venta.Cliente.nombre,
                                                 TipoFactura = Venta.TipoFactura.descripcion,
                                                 FormaPago = Venta.FormaPago.descripcion,
                                                 Total = Venta.total,
                                                 Estado = (Venta.estado == 1 ? "Activo" : "Inactivo")

                                             };
                return oventas.ToList();
            }


        }

        public List<Object> ListarFecha(DateTime fechaInicio, DateTime fechaFinal)
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oventas = from Venta in db.Venta.Include("Usuario, TipoFactura, FormaPago, Cliente, Empleado")
                                             where (Venta.fechaAlta) >= fechaInicio && (Venta.fechaAlta) <= fechaFinal
                                             select new
                                             {
                                                 NroVenta = Venta.idVenta,
                                                 Fecha = Venta.fechaAlta,
                                                 Cajero = Venta.Usuario.Empleado.apellido + " " + Venta.Usuario.Empleado.nombre,
                                                 Cliente = Venta.Cliente.apellido + " " + Venta.Cliente.nombre,
                                                 TipoFactura = Venta.TipoFactura.descripcion,
                                                 FormaPago = Venta.FormaPago.descripcion,
                                                 Total = Venta.total,
                                                 Estado = (Venta.estado == 1 ? "Activo" : "Inactivo")

                                             };
                return oventas.ToList();
            }


        }

        public List<Venta> ListaVenta()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<Venta> oVenta = db.Venta.ToList();

                return oVenta;
            }


        }

        public Venta UnaVenta(int pIdVenta)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Venta ventaActual = db.Venta.Where(s => s.idVenta == pIdVenta).First();
                    return ventaActual;
                }
                catch
                {
                    return null;
                }
            }


        }

        public Boolean VentaExiste(int pIdVenta)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean ventaExiste = false;
                List<Venta> listaVenta = ListaVenta();

                foreach (var UnaVenta in listaVenta)
                {
                    //Empleado empl = (Empleado)unEmpleado;
                    if (pIdVenta == UnaVenta.idVenta)
                    {
                        ventaExiste = true;
                    }
                }

                return ventaExiste;
            }

        }

        public List<TipoFactura> ListaTF()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<TipoFactura> tf = db.TipoFactura.ToList();

                return tf;
            }


        }

        public Boolean TipoFacturaExiste(string pTipoFactura)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean tfExiste = false;
                List<TipoFactura> listatf = ListaTF();

                foreach (var untf in listatf)
                {
                    
                    if (pTipoFactura.ToString().ToUpper() == untf.descripcion.ToString().ToUpper())
                    {
                        tfExiste = true;
                    }
                }

                return tfExiste;
            }

        }

        public List<FormaPago> ListaFP()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<FormaPago> fp = db.FormaPago.ToList();

                return fp;
            }


        }

        public Boolean FormaPagoExiste(string pFormaPago)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean fpExiste = false;
                List<FormaPago> listafp = ListaFP();

                foreach (var unfp in listafp)
                {

                    if (pFormaPago.ToString().ToUpper() == unfp.descripcion.ToString().ToUpper())
                    {
                        fpExiste = true;
                    }
                }

                return fpExiste;
            }

        }

    }
}

