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
        CD_Producto producto = new CD_Producto();
        public void agregarProducto(long pCodigo, string pNombre, string pCategoria, string pProveedor, int pStock, int pStockMinimo, decimal pPrecioVenta, string pDescripcion, int pEstado)
        {
            
            producto.agregarProducto(pCodigo, pNombre, pCategoria, pProveedor, pStock, pStockMinimo, pPrecioVenta, pDescripcion,pEstado);
        }

        public void editarProducto(long pCodigo, string pNombre, string pCategoria, string pProveedor, int pStock, int pStockMinimo, decimal pPrecioVenta, string pDescripcion, int pEstado)
        {
            producto.editarProducto(pCodigo, pNombre, pCategoria,pProveedor, pStock, pStockMinimo, pPrecioVenta, pDescripcion, pEstado);
        }
        public List<Object> Listar()
        {
            return producto.Listar();
                       
        }

        public List<Object> ListarConsulta()
        {
            return producto.ListarConsulta();

        }

        public List<Producto> ListaProducto()
        {
            return producto.ListaProducto();
        }

        public Producto UnProducto(long pCodigo)
        {
            return producto.UnProducto(pCodigo);


        }

        public Boolean ProductoExiste(long pCodigo)
        {
            return producto.ProductoExiste(pCodigo);

        }

        public List<Object> Categorias()
        {
            return producto.Categorias();
        }
    }
}
