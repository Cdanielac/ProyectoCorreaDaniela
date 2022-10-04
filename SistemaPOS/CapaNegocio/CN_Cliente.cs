using CapaDatos.Entity;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        public void agregarCliente(int pDni, string pApellido, string pNombre, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            CD_Cliente cliente = new CD_Cliente();
            cliente.agregarCliente(pDni, pApellido, pNombre, pEmail, pTelefono, pDireccion, pEstado);
        }

        public void editarCliente(int pDni, string pApellido, string pNombre, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            CD_Cliente cliente = new CD_Cliente();
            cliente.editarCliente(pDni, pApellido, pNombre, pEmail, pTelefono, pDireccion, pEstado);
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
