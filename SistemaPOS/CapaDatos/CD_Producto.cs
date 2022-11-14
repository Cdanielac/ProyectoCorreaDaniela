using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Producto
    {
        public void agregarProducto(long pCodigo, string pNombre, string pCategoria, string pProveedor, int pStock, int pStockMinimo, decimal pPrecioVenta, string pDescripcion, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Producto nuevoProducto = new Producto();

                Categoria categoriaSelect = db.Categoria.Where(s => s.descripcion == pCategoria).FirstOrDefault();
                Proveedor proveedorSelect = db.Proveedor.Where(s => s.razonSocial == pProveedor).FirstOrDefault();

                nuevoProducto.codProducto = pCodigo;
                nuevoProducto.nombre = pNombre;
                nuevoProducto.idCategoria = categoriaSelect.idCategoria;
                nuevoProducto.idProveedor = proveedorSelect.idProveedor;
                nuevoProducto.stock = pStock;
                nuevoProducto.stockMinimo = pStockMinimo;
                nuevoProducto.precioVenta = pPrecioVenta;
                nuevoProducto.descripcion = pDescripcion;
                nuevoProducto.estado = pEstado;
                nuevoProducto.fechaAlta = DateTime.Now;


                db.Producto.Add(nuevoProducto);
                db.SaveChanges();
            }
        }

        public void editarProducto(long pCodigo, string pNombre, string pCategoria, string pProveedor, int pStock, int pStockMinimo, decimal pPrecioVenta, string pDescripcion, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                
                Producto productoSelect = db.Producto.Where(s => s.codProducto == pCodigo).First();
                Categoria categoriaSelect = db.Categoria.Where(s => s.descripcion == pCategoria).First();
                Proveedor proveedorSelect = db.Proveedor.Where(s => s.razonSocial == pProveedor).First();


                productoSelect.codProducto = pCodigo;
                productoSelect.nombre = pNombre;
                productoSelect.idCategoria = categoriaSelect.idCategoria;
                productoSelect.idProveedor = proveedorSelect.idProveedor;
                productoSelect.stock = pStock;
                productoSelect.stockMinimo = pStockMinimo;
                productoSelect.precioVenta = pPrecioVenta;
                productoSelect.descripcion = pDescripcion;
                productoSelect.estado = pEstado;

                db.Entry(productoSelect).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                


            }
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
                                                   PROVEEDOR = Producto.Proveedor.razonSocial,
                                                   STOCK = Producto.stock,
                                                   STOKMINIMO = Producto.stockMinimo,
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
                                               where Producto.stock > 0 && Producto.estado == 1
                                               select new
                                               {
                                                   IDPRODUCTO = Producto.idProducto,
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

        public Producto UnProducto(long pCodigo)
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

        public Boolean ProductoExiste(long pCodigo)
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
 
