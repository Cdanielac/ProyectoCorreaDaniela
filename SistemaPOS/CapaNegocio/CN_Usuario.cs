using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Entity;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        public void agregarUsuario(int pDni, string pUsuario, string pRol, string pContraseña,int pEstado)
        {
            CD_Usuario usuario = new CD_Usuario();
            usuario.agregarUsuario(pDni, pUsuario, pRol, pContraseña, pEstado);
        }

        public void editarUsuario(int pDni, string pUsuario, string pRol, string pContraseña, int pEstado)
        {
            CD_Usuario empleado = new CD_Usuario();
            empleado.editarUsuario(pDni, pUsuario, pRol, pContraseña, pEstado);
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


    }
}
