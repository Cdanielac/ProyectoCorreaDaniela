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
        CD_Cliente clientes = new CD_Cliente();
        public void agregarCliente(int pDni, string pApellido, string pNombre, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            clientes.agregarCliente(pDni, pApellido, pNombre, pEmail, pTelefono, pDireccion, pEstado);
        }

        public void editarCliente(int pDni, string pApellido, string pNombre, string pEmail, int pTelefono, string pDireccion, int pEstado)
        {
            clientes.editarCliente(pDni, pApellido, pNombre, pEmail, pTelefono, pDireccion, pEstado);
        }

        public List<Object> Listar()
        {
            return clientes.Listar();
        }


        public List<Cliente> ListaCliente()
        {
            return clientes.ListaCliente();

        }

        public List<Object> ListarConsulta()
        {
            return clientes.ListarConsulta();

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


        public Cliente UnCliente(long pDni)
        {
            return clientes.UnCliente(pDni);
        }



        public Boolean DniExiste(long pDni)
        {
            return clientes.DniExiste(pDni);

        }
    }
}
