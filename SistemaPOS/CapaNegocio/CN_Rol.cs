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
        public List<Rol> ListaRol()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<Rol> oUsuario = db.Rol.ToList();

                return oUsuario;
            }


        }

        public Rol UnRol(int pIdRol)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Rol rolSelect = db.Rol.Where(s => s.idRol == pIdRol).First();
                    return rolSelect;
                }
                catch
                {
                    return null;
                }
            }


        }
    }
}
