using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Empleado
    {
        public void agregarEmpleado(int pDni, string pApellido, string pNombre, string pEmail, string pDireccion, int pTelefono, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Empleado nuevoEmpleado = new Empleado();

                nuevoEmpleado.dni = pDni;
                nuevoEmpleado.apellido = pApellido;
                nuevoEmpleado.nombre = pNombre;
                nuevoEmpleado.email = pEmail;
                nuevoEmpleado.direccion = pDireccion;
                nuevoEmpleado.telefono = pTelefono;
                nuevoEmpleado.estado = pEstado;
                nuevoEmpleado.fechaAlta = DateTime.Now;

                db.Empleado.Add(nuevoEmpleado);
                db.SaveChanges();
            }
        }

        public void editarEmpleado(int pDni, string pApellido, string pNombre, string pEmail, string pDireccion, int pTelefono, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                //Empleado empleadoSelect = db.Empleado.Where(s => s.dni == pDni).First();
                Empleado pEmpleado = new Empleado();

                pEmpleado.dni = pDni;   
                pEmpleado.apellido = pApellido;
                pEmpleado.nombre = pNombre; 
                pEmpleado.email = pEmail;
                pEmpleado.direccion = pDireccion;
                pEmpleado.telefono = pTelefono;
                pEmpleado.estado = pEstado;
                pEmpleado.fechaAlta = DateTime.Now;
               
                db.Entry(pEmpleado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }

}
