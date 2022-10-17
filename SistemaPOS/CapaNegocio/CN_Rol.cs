using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Rol
    {
        CD_Rol roles = new CD_Rol();
        public List<Rol> ListaRol()
        {
            return roles.ListaRol();

        }

        public Rol UnRol(int pIdRol)
        {
            return roles.UnRol(pIdRol);

        }
    }
}
