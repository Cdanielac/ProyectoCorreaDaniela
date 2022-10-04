using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Data.Entity.Infrastructure;
using CapaDatos.Entity;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public void agregarUsuario(int pDni, string pUsuario, string pRol, string pContraseña, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Usuario nuevoUsuario = new Usuario();

                Rol rolSelec = db.Rol.Where(s => s.descripcion == pRol).FirstOrDefault();
                Empleado empleadoSelect = db.Empleado.Where(s => s.dni == pDni).FirstOrDefault();

                nuevoUsuario.dni = empleadoSelect.dni;
                nuevoUsuario.usuario1 = pUsuario;
                nuevoUsuario.idRol = rolSelec.idRol;
                nuevoUsuario.contraseña = pContraseña;
                nuevoUsuario.estado = pEstado;
                nuevoUsuario.fechaAlta = DateTime.Now;

                db.Usuario.Add(nuevoUsuario);
                db.SaveChanges();
            }
        }

        public void editarUsuario(int pDni, string pUsuario, string pRol, string pContraseña, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Usuario usuarioSelect = db.Usuario.Where(s => s.dni == pDni).First();
                //Usuario pUser = new Usuario();
                Rol rolSelec = db.Rol.Where(s => s.descripcion == pRol).FirstOrDefault();
                Empleado empleadoSelect = db.Empleado.Where(s => s.dni == pDni).FirstOrDefault();

                usuarioSelect.dni = empleadoSelect.dni;
                usuarioSelect.usuario1 = pUsuario;
                usuarioSelect.idRol = rolSelec.idRol;
                usuarioSelect.contraseña = pContraseña;
                usuarioSelect.estado = pEstado;
                usuarioSelect.fechaAlta = DateTime.Now;

                db.Entry(usuarioSelect).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}
