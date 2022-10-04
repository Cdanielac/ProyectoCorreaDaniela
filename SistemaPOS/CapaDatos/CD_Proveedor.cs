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
    }
}
