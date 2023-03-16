using CapaDatos.Entity;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class CN_Compra
    {
        public void agregarCompra(int pTipoFactura, int pUsuario, int pProveedor,int pFormaPago, int pEstado)
        {
            CD_Compra compra = new CD_Compra();
            compra.agregarCompra(pTipoFactura,pUsuario,pProveedor,pFormaPago,pEstado);
        }


        public List<Object> ListarCompra()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oCompra = from Compra in db.Compra.Include("TipoFactura" + "Usuario" + "FormaPago" + "Proveedor")
                                               select new
                                               {                                            
                                                   NROCOMPRA = Compra.idCompra,
                                                   TIPOFACTURA = Compra.TipoFactura.descripcion,
                                                   USUARIO = Compra.Usuario.usuario1,
                                                   PROVEEDOR = Compra.Proveedor.razonSocial,
                                                   TOTAL = Compra.total
                                                  
                                               };
                return oCompra.ToList();
            }


        }

        public List<Object> ListarDetalleCompra()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oDetalleCompra = from DetalleCompra in db.DetalleCompra.Include("Compra" + "Producto")
                                             select new
                                             {

                                                 NROCOMPRA = DetalleCompra.Compra.idCompra,
                                                 CODIGO = DetalleCompra.Producto.codProducto,
                                                 PRODUCTO = DetalleCompra.Producto.nombre,
                                                 CANTIDAD = DetalleCompra.cantidad,
                                                 SUBTOTAL = DetalleCompra.subtotal

                                             };
                return oDetalleCompra.ToList();     
            }


        }
        public List<Compra> ListaCompra()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<Compra> oCompra = db.Compra.ToList();

                return oCompra;
            }


        }

       
        public Compra UnaCompra(int pNroCompra)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Compra compraActual = db.Compra.Where(s => s.idCompra == pNroCompra).First();
                    return compraActual;
                }
                catch
                {
                    return null;
                }
            }


        }

        public Boolean CompraExiste(int pNroCompra)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean compraExiste = false;
                List<Compra> listaCompra = ListaCompra();

                foreach (var unaCompra in listaCompra)
                {
                    if (pNroCompra == unaCompra.idCompra)
                    {
                        compraExiste = true;
                    }
                }

                return compraExiste;
            }

        }

        public List<Object> Proveedor()
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> listaProveedor = from Proveedor in db.Proveedor
                                                    select Proveedor.razonSocial;
                return listaProveedor.ToList();
            }
        }

        public List<Object> TipoFactura()
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> listaTipoFactura = from TipoFactura in db.TipoFactura
                                                    select TipoFactura.descripcion;
                return listaTipoFactura.ToList();
            }
        }

        public List<Object> FormaPago()
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> listaFormaPago = from FormaPago in db.FormaPago
                                                      select FormaPago.descripcion;
                return listaFormaPago.ToList();
            }
        }
    }
}
