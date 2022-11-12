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
using System.Security.Cryptography;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public void agregarUsuario(int pDni, string pUsuario, string pRol, string pContraseña, int pEstado)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Usuario nuevoUsuario = new Usuario();
                string contraseñaEncrip = GetSHA256(pContraseña);

                Rol rolSelec = db.Rol.Where(s => s.descripcion == pRol).FirstOrDefault();
                Empleado empleadoSelect = db.Empleado.Where(s => s.dni == pDni).FirstOrDefault();

                nuevoUsuario.dni = empleadoSelect.dni;
                nuevoUsuario.usuario1 = pUsuario;
                nuevoUsuario.idRol = rolSelec.idRol;
                nuevoUsuario.contraseña = contraseñaEncrip;
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
                if (pContraseña == usuarioSelect.contraseña )
                {
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
                else
                {
                    string contraseñaEncrip = GetSHA256(pContraseña);
                    Rol rolSelec = db.Rol.Where(s => s.descripcion == pRol).FirstOrDefault();
                    Empleado empleadoSelect = db.Empleado.Where(s => s.dni == pDni).FirstOrDefault();

                    usuarioSelect.dni = empleadoSelect.dni;
                    usuarioSelect.usuario1 = pUsuario;
                    usuarioSelect.idRol = rolSelec.idRol;
                    usuarioSelect.contraseña = contraseñaEncrip;
                    usuarioSelect.estado = pEstado;
                    usuarioSelect.fechaAlta = DateTime.Now;

                    db.Entry(usuarioSelect).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                
            }
        }

        public List<Object> Listar()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> ousuario = from Usuario in db.Usuario.Include("Rol")
                                              select new
                                              {
                                                  //idUsuario = Usuario.idUsuario,
                                                  DNI = Usuario.dni,
                                                  ROL = Usuario.Rol.descripcion,
                                                  USUARIO = Usuario.usuario1,
                                                  CONTRASEÑA = Usuario.contraseña,
                                                  CEstado = Usuario.estado,
                                                  ESTADO = (Usuario.estado == 1 ? "Activo" : "Inactivo")

                                              };
                return ousuario.ToList();
            }


        }

        public List<Usuario> ListaUsuario()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<Usuario> oUsuario = db.Usuario.ToList();

                return oUsuario;
            }


        }

        public Usuario UnUsuario(int pDni)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Usuario usuarioActual = db.Usuario.Where(s => s.dni == pDni).First();
                    return usuarioActual;
                }
                catch
                {
                    return null;
                }
            }


        }

        public Boolean UsuarioExiste(int pDni)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean usuarioExiste = false;
                List<Usuario> listaUsuario = ListaUsuario();

                foreach (var UnUsuario in listaUsuario)
                {
                    //Empleado empl = (Empleado)unEmpleado;
                    if (pDni == UnUsuario.dni)
                    {
                        usuarioExiste = true;
                    }
                }

                return usuarioExiste;
            }

        }

        public List<Object> roles()
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> listaRoles = from Rol in db.Rol
                                                select Rol.descripcion;
                return listaRoles.ToList();
            }
        }

        public string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

    }
}
