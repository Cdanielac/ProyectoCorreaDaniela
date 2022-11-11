using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Conexion_DS
    {
        CD_Conexion_DS conexion_DS = new CD_Conexion_DS();
        public bool EjecutarQuery(string SQL)
        {
            return conexion_DS.EjecutarQuery(SQL);
        }
        public DataSet QueryConsultaDataSet(string Q)
        {

            return conexion_DS.QueryConsultaDataSet(Q);

        }
        public DataTable EjecutarConsulta(string SQL)
        {
            return conexion_DS.EjecutarConsulta(SQL);
        }

        public bool resguardarDatos(string pNombreResguardo, string pPath)
        {
            return conexion_DS.resguardarDatos(pNombreResguardo,pPath);
        }
    }
}
