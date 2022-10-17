using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public void agregarProveedor(int pCodigo, string pRazonSocial, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Proveedor nuevoProveedor = new Proveedor();

                nuevoProveedor.codProveedor = pCodigo;
                nuevoProveedor.razonSocial = pRazonSocial;
                nuevoProveedor.email = pEmail;
                nuevoProveedor.telefono = pTelefono;
                nuevoProveedor.direccion = pDireccion;
                nuevoProveedor.estado = pEstado;
                nuevoProveedor.fechaAlta = DateTime.Now;


                db.Proveedor.Add(nuevoProveedor);
                db.SaveChanges();
            }
        }

        public void editarProveedor(int pCodigo, string pRazonSocial, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Proveedor proveedorSelect = db.Proveedor.Where(s => s.codProveedor == pCodigo).First();
                                
                proveedorSelect.razonSocial = pRazonSocial;
                proveedorSelect.email = pEmail;
                proveedorSelect.telefono = pTelefono;
                proveedorSelect.direccion = pDireccion;
                proveedorSelect.estado = pEstado;
                
                db.Entry(proveedorSelect).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
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
