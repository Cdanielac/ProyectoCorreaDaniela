using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Entity;


namespace CapaNegocio
{
    public class CN_Empleado
    {
        public void agregarEmpleado(int pDni, string pApellido, string pNombre, string pEmail, string pDireccion, int pTelefono, int pEstado)
        {
            CD_Empleado empleado = new CD_Empleado();
            empleado.agregarEmpleado(pDni,pApellido, pNombre, pEmail, pDireccion, pTelefono, pEstado); 
        }

        public void editarEmpleado(int pDni, string pApellido, string pNombre, string pEmail, string pDireccion, int pTelefono, int pEstado)
        {
            CD_Empleado empleado = new CD_Empleado();
            empleado.editarEmpleado(pDni, pApellido, pNombre, pEmail, pDireccion, pTelefono, pEstado);
        }

        public List<Object> Listar()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oEmpleado = from Empleado in db.Empleado
                                               select new
                                               {
                                                   DNI = Empleado.dni,
                                                   APELLIDO = Empleado.apellido,
                                                   NOMBRE = Empleado.nombre,
                                                   EMAIL = Empleado.email,
                                                   DIRECCION = Empleado.direccion,
                                                   TELEFONO = Empleado.telefono,
                                                   ESTADO = (Empleado.estado == 1 ? "Activo" : "Inactivo")

                                               };
                return oEmpleado.ToList();
            }


        }


        public List<Empleado> ListaEmpleado()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {


                List<Empleado> oEmpleado = db.Empleado.ToList();

                return oEmpleado;


            }

        }

        public List<int> ListaDNI()
        {

            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<int> listaDNI = from Empleado in db.Empleado
                                           select Empleado.dni;
                return listaDNI.ToList();

            }

        }


        public Empleado UnEmpleado(int pDni)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Empleado empleadoSelect = db.Empleado.Where(s => s.dni == pDni).First();
                    return empleadoSelect;
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
                List<Empleado> listaEmpleado = ListaEmpleado();

                foreach (var unEmpleado in listaEmpleado)
                {
                    //Empleado empl = (Empleado)unEmpleado;
                    if (pDni == unEmpleado.dni)
                    {
                        dniExiste = true;
                    }
                }

                return dniExiste;
            }

        }
    }
}
