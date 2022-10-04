using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entity;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Producto
    {
        public void agregarProducto(int pCodigo, string pNombre, string pCategoria, int pStock, int pStockMinimo, decimal pPrecioCompra, decimal pPrecioVenta, string pDescripcion, int pEstado)
        {
            CD_Producto producto = new CD_Producto();
            producto.agregarProducto(pCodigo, pNombre, pCategoria, pStock, pStockMinimo, pPrecioCompra, pPrecioVenta, pDescripcion,pEstado);
        }

        public void editarProducto(int pCodigo, string pNombre, string pCategoria, int pStock, int pStockMinimo, decimal pPrecioCompra, decimal pPrecioVenta, string pDescripcion, int pEstado)
        {
            CD_Producto producto = new CD_Producto();
            producto.editarProducto(pCodigo, pNombre, pCategoria, pStock, pStockMinimo, pPrecioCompra, pPrecioVenta, pDescripcion, pEstado);
        }
        public List<Object> Listar()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oProducto = from Producto in db.Producto.Include("Categoria" + "Proveedor")
                                              select new
                                              {
                                                  //idProducto = Producto.idProducto,
                                                  CODIGO = Producto.codProducto,
                                                  NOMBRE = Producto.nombre,
                                                  CATEGORÍA = Producto.Categoria.descripcion,
                                                  STOCK = Producto.stock,
                                                  STOKMINIMO = Producto.stockMinimo,
                                                  PRECIOCOMPRA = Producto.precioCompra,
                                                  PRECIOVENTA = Producto.precioVenta,
                                                  DESCRIPCIÓN = Producto.descripcion,
                                                  ESTADO = (Producto.estado == 1 ? "Activo" : "Inactivo")
                                              };
                return oProducto.ToList();
            }


        }

        public List<Object> ListarConsulta()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oProducto = from Producto in db.Producto.Include("Categoria" + "Proveedor")
                                               select new
                                               {
                                                   //idProducto = Producto.idProducto,
                                                   CODIGO = Producto.codProducto,
                                                   NOMBRE = Producto.nombre,
                                                   CATEGORÍA = Producto.Categoria.descripcion,
                                                   STOCK = Producto.stock,
                                                   PRECIOVENTA = Producto.precioVenta,
                                                   DESCRIPCIÓN = Producto.descripcion,
                                                   ESTADO = (Producto.estado == 1 ? "Activo" : "Inactivo")
                                               };
                return oProducto.ToList();
            }


        }

        public List<Producto> ListaProducto()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<Producto> oProducto = db.Producto.ToList();

                return oProducto;
            }


        }

        public Producto UnProducto(int pCodigo)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Producto productoActual = db.Producto.Where(s => s.codProducto == pCodigo).First();
                    return productoActual;
                }
                catch
                {
                    return null;
                }
            }


        }

        public Boolean ProductoExiste(int pCodigo)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean productoExiste = false;
                List<Producto> listaProducto = ListaProducto();

                foreach (var UnProducto in listaProducto)
                {
                    if (pCodigo == UnProducto.codProducto)
                    {
                        productoExiste = true;
                    }
                }

                return productoExiste;
            }

        }

        public List<Object> Categorias()
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> listaCategoria = from Categoria in db.Categoria
                                                select Categoria.descripcion;
                return listaCategoria.ToList();
            }
        }
    }
}
