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

        public List<Object> Listar()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oCliente = from Cliente in db.Cliente
                                              select new
                                              {
                                                  DNI = Cliente.dni,
                                                  APELLIDO = Cliente.apellido,
                                                  NOMBRE = Cliente.nombre,
                                                  EMAIL = Cliente.email,
                                                  TELEFONO = Cliente.telefono,
                                                  DIRECCION = Cliente.direccion,
                                                  ESTADO = (Cliente.estado == 1 ? "Activo" : "Inactivo")

                                              };
                return oCliente.ToList();
            }


        }


        public List<Cliente> ListaCliente()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {


                List<Cliente> oCliente = db.Cliente.ToList();

                return oCliente;


            }

        }

        //public List<int> ListaDNI()
        //{

        //    using (DB_POSEntities db = new DB_POSEntities())
        //    {
        //        IQueryable<int> listaDNI = from Cliente in db.Cliente
        //                                   select Cliente.dni;
        //        return listaDNI.ToList();

        //    }

        //}


        public Cliente UnCliente(int pDni)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Cliente clienteSelect = db.Cliente.Where(s => s.dni == pDni).First();
                    return clienteSelect;
                }
                catch
                {
                    return null;
                }
            }
        }



        public Boolean DniExiste(int pDni)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean dniExiste = false;
                List<Cliente> listaCliente = ListaCliente();

                foreach (var unCliente in listaCliente)
                {
                    //Empleado empl = (Empleado)unEmpleado;
                    if (pDni == unCliente.dni)
                    {
                        dniExiste = true;
                    }
                }

                return dniExiste;
            }

        }
    }
}
