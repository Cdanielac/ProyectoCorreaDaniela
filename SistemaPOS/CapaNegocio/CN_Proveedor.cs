using CapaDatos.Entity;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        CD_Proveedor proveedor = new CD_Proveedor();
        public void agregarProveedor(int pCodigo, string pRazonSocial, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            proveedor.agregarProveedor(pCodigo, pRazonSocial, pEmail, pTelefono, pDireccion, pEstado);
        }

        public void editarProveedor(int pCodigo, string pRazonSocial, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            proveedor.editarProveedor(pCodigo, pRazonSocial, pEmail, pTelefono, pDireccion, pEstado);
        }
        public List<Object> Listar()
        {
            return proveedor.Listar();  

        }

        public List<Proveedor> ListaProveedor()
        {
            return proveedor.ListaProveedor();
        }

        public Proveedor UnProveedor(int pCodigo)
        {
            return proveedor.UnProveedor(pCodigo);


        }

        public Boolean ProveedorExiste(int pCodigo)
        {
            return proveedor.ProveedorExiste(pCodigo);

        }
    }
}
