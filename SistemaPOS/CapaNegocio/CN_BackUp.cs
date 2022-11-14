using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_BackUp
    {
        CD_BackUp conexion_DS = new CD_BackUp();
        

        public bool crearBackUp(string pNombreResguardo, string pPath)
        {
            return conexion_DS.crearBackUp(pNombreResguardo,pPath);
        }

        public bool restaurarBD(string p_direccion)
        {
            return conexion_DS.restaurarBD(p_direccion);
        }
    }
}
