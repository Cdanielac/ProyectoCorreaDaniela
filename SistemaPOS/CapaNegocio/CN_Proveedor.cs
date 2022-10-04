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
        public void agregarProveedor(int pCodigo, string pRazonSocial, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            CD_Proveedor proveedor = new CD_Proveedor();
            proveedor.agregarProveedor(pCodigo, pRazonSocial, pEmail, pTelefono, pDireccion, pEstado);
        }

        public void editarProveedor(int pCodigo, string pRazonSocial, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            CD_Proveedor proveedor = new CD_Proveedor();
            proveedor.editarProveedor(pCodigo, pRazonSocial, pEmail, pTelefono, pDireccion, pEstado);
        }
        public List<Object> Listar()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oProveedor = from Proveedor in db.Proveedor
                                                select new
                                                {
                                                    //idProveedor = Proveedor.idProveedor,
                                                    CODIGO = Proveedor.codProveedor,
                                                    RAZONSOCIAL = Proveedor.razonSocial,
                                                    EMAIL = Proveedor.email,
                                                    TELEFONO = Proveedor.telefono,
                                                    DIRECCION = Proveedor.direccion,
                                                    ESTADO = (Proveedor.estado == 1 ? "Activo" : "Inactivo")
                                                };
                return oProveedor.ToList();
            }


        }

        public List<Proveedor> ListaProveedor()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<Proveedor> oProveedor = db.Proveedor.ToList();

                return oProveedor;
            }


        }

        public Proveedor UnProveedor(int pCodigo)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Proveedor proveedorActual = db.Proveedor.Where(s => s.codProveedor == pCodigo).First();
                    return proveedorActual;
                }
                catch
                {
                    return null;
                }
            }


        }

        public Boolean ProveedorExiste(int pCodigo)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean proveedorExiste = false;
                List<Proveedor> listaProveedor = ListaProveedor();

                foreach (var UnProveedor in listaProveedor)
                {
                    if (pCodigo == UnProveedor.codProveedor)
                    {
                        proveedorExiste = true;
                    }
                }

                return proveedorExiste;
            }

        }
    }
}
