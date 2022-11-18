using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Entity;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        CD_Usuario usuarios = new CD_Usuario();
        public void agregarUsuario(Int64 pDni, string pUsuario, string pRol, string pContraseña,int pEstado)
        {
            usuarios.agregarUsuario(pDni, pUsuario, pRol, pContraseña, pEstado);
        }

        public void editarUsuario(Int64 pDni, string pUsuario, string pRol, string pContraseña, int pEstado)
        {
            usuarios.editarUsuario(pDni, pUsuario, pRol, pContraseña, pEstado);
        }

        public List<Object> Listar()
        {
            return usuarios.Listar();
        }

        public List<Usuario> ListaUsuario()
        {
            return usuarios.ListaUsuario(); 

        }

        public Usuario UnUsuario(Int64 pDni)
        {
            return usuarios.UnUsuario(pDni);


        }

        public Boolean UsuarioExiste(Int64 pDni)
        {
            return usuarios.UsuarioExiste(pDni);

        }

        public List<Object> roles()
        {
            return usuarios.roles();
        }

        public string GetSHA256(string str)
        {
            return usuarios.GetSHA256(str);
        }

        public void desactivarUsuario(Int64 pdni)
        {
            usuarios.desactivarUsuario(pdni);
        }

        public void activarUsuario(Int64 pdni)
        {
            usuarios.activarUsuario(pdni);
        }


    }
}
