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
        CD_Empleado empleados = new CD_Empleado();
        public void agregarEmpleado(int pDni, string pApellido, string pNombre, string pEmail, string pDireccion, int pTelefono, int pEstado)
        {
          empleados.agregarEmpleado(pDni,pApellido, pNombre, pEmail, pDireccion, pTelefono, pEstado); 
        }

        public void editarEmpleado(int pDni, string pApellido, string pNombre, string pEmail, string pDireccion, int pTelefono, int pEstado)
        {
            empleados.editarEmpleado(pDni, pApellido, pNombre, pEmail, pDireccion, pTelefono, pEstado);
        }

        public List<Object> Listar()
        {
            return empleados.Listar();
        }


        public List<Empleado> ListaEmpleado()
        {
            return empleados.ListaEmpleado();
        }

        public List<int> ListaDNI()
        {
            return empleados.ListaDNI();

        }


        public Empleado UnEmpleado(int pDni)
        {
            return empleados.UnEmpleado(pDni);
        }



        public Boolean DniExiste(int pDni)
        {
            return empleados.DniExiste(pDni);

        }
    }
}
