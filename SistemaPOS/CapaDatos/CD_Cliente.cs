using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public void agregarCliente(int pDni, string pApellido, string pNombre, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Cliente nuevoCliente = new Cliente();

                nuevoCliente.dni = pDni;
                nuevoCliente.apellido = pApellido;
                nuevoCliente.nombre = pNombre;
                nuevoCliente.email = pEmail;
                nuevoCliente.direccion = pDireccion;
                nuevoCliente.telefono = pTelefono;
                nuevoCliente.estado = pEstado;
                nuevoCliente.fechaAlta = DateTime.Now;

                db.Cliente.Add(nuevoCliente);
                db.SaveChanges();
            }
        }

        public void editarCliente(int pDni, string pApellido, string pNombre, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Cliente clienteSelect = db.Cliente.Where(s => s.dni == pDni).First();

                clienteSelect.dni = pDni;
                clienteSelect.apellido = pApellido;
                clienteSelect.nombre = pNombre;
                clienteSelect.email = pEmail;
                clienteSelect.telefono = pTelefono;
                clienteSelect.direccion = pDireccion;
                clienteSelect.estado = pEstado;

                //Cliente pCliente = new Cliente();
                //pCliente.idCliente = clienteSelect.idCliente;

                //pCliente.dni = clienteSelect.dni;
                //pCliente.apellido = clienteSelect.apellido;
                //pCliente.nombre = clienteSelect.nombre;
                //pCliente.email = clienteSelect.email;
                //pCliente.direccion = clienteSelect.direccion;
                //pCliente.telefono = clienteSelect.telefono;
                //pCliente.estado = clienteSelect.estado;
                //pCliente.fechaAlta = DateTime.Now;

                db.Entry(clienteSelect).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                //try
                //{
                //    db.SaveChanges();
                //}
                //catch (DbUpdateConcurrencyException ex)
                //{
                //    // Update original values from the database
                //    //var entry = ex.Entries.Single();
                //    //entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                //    //ex.Entries.Single().Reload();
                //}


            }
        }
    }
}
