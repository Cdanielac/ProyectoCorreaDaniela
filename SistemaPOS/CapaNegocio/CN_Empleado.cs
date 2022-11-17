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
        public void agregarEmpleado(Int64 pDni, string pApellido, string pNombre, string pEmail, string pDireccion, long pTelefono, int pEstado)
        {
            empleados.agregarEmpleado(pDni, pApellido, pNombre, pEmail, pDireccion, pTelefono, pEstado);
        }

        public void editarEmpleado(Int64 pDni, string pApellido, string pNombre, string pEmail, string pDireccion, long pTelefono, int pEstado)
        {
            empleados.editarEmpleado(pDni, pApellido, pNombre, pEmail, pDireccion, pTelefono, pEstado);
        }

        public List<Object> Listar()
        {
            return empleados.Listar();
        }

        public List<Object> ListarConsulta()
        {
            return empleados.ListarConsulta();

        }

        public List<Empleado> ListaEmpleado()
        {
            return empleados.ListaEmpleado();
        }

        public List<Int64> ListaDNI()
        {
            return empleados.ListaDNI();

        }

        public Empleado UnEmpleado(Int64 pDni)
        {
            return empleados.UnEmpleado(pDni);
        }

        public Boolean DniExiste(Int64 pDni)
        {
            return empleados.DniExiste(pDni);

        }

        public Boolean EmailExiste(string pEmail)
        {
            return empleados.EmailExiste(pEmail);

        }

        public void desactivarEmpleado(Int64 pdni)
        {
            empleados.desactivarEmpleado(pdni);
        }

        public void activarEmpleado(Int64 pdni)
        {
            empleados.activarEmpleado(pdni);
        }
    }
}
