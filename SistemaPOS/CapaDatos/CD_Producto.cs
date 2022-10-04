using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Producto
    {
        public void agregarProducto(int pCodigo, string pNombre, string pCategoria, int pStock, int pStockMinimo, decimal pPrecioCompra, decimal pPrecioVenta, string pDescripcion, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Producto nuevoProducto = new Producto();

                Categoria categoriaSelect = db.Categoria.Where(s => s.descripcion == pCategoria).FirstOrDefault();
                
                nuevoProducto.codProducto = pCodigo;
                nuevoProducto.nombre = pNombre;
                nuevoProducto.idCategoria = categoriaSelect.idCategoria;
                nuevoProducto.stock = pStock;
                nuevoProducto.stockMinimo = pStockMinimo;
                nuevoProducto.precioCompra = pPrecioCompra;
                nuevoProducto.precioVenta = pPrecioVenta;
                nuevoProducto.descripcion = pDescripcion;
                nuevoProducto.estado = pEstado;
                nuevoProducto.fechaAlta = DateTime.Now;


                db.Producto.Add(nuevoProducto);
                db.SaveChanges();
            }
        }

        public void editarProducto(int pCodigo, string pNombre, string pCategoria, int pStock, int pStockMinimo, decimal pPrecioCompra, decimal pPrecioVenta, string pDescripcion, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Producto productoSelect = db.Producto.Where(s => s.codProducto == pCodigo).First();
                Producto categoriaSelect = db.Producto.Where(s => s.descripcion == pCategoria).First();

                productoSelect.codProducto = pCodigo;
                productoSelect.nombre = pNombre;
                productoSelect.idCategoria = categoriaSelect.idCategoria;
                productoSelect.stock = pStock;
                productoSelect.stockMinimo = pStockMinimo;
                productoSelect.precioCompra = pPrecioCompra;
                productoSelect.precioVenta = pPrecioVenta;
                productoSelect.descripcion = pDescripcion;
                productoSelect.estado = pEstado;

                db.Entry(productoSelect).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                


            }
        }
    }
}
