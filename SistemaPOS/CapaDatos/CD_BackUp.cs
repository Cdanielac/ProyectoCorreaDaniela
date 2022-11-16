using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using CapaDatos.Entity;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace CapaDatos
{
    public class CD_BackUp
    {
        public static SqlConnection cnx = new SqlConnection("Data Source = DESKTOP - C26D9LB; Initial Catalog = DB_POS; Integrated Security = True");


        public bool crearBackUp(string pNombreResguardo, string pPath)
        {
            //try
            //{

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("crearBackup");
                cmd.Parameters.AddWithValue("@nombre", pNombreResguardo);
                cmd.Parameters.AddWithValue("@ubicacion", pPath);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            return true;
            //}
            //catch
            //{
            //return false;
            //}

            //string ruta = pPath;
            //using (DB_POSEntities db = new DB_POSEntities())
            //{
            //    string DB = db.Database.Connection.Database;
            //    string sqlCommand = "BACKUP DATABASE [{0}] TO  DISK = N'{1}' WITH NOFORMAT, NOINIT,  " +
            //        "NAME = N'DB_POS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            //    db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, DB, ruta));

            //    return true;
            //}
        }

        public bool restaurarBD(string p_direccion)
        {
            //try
            //{

            using (DB_POSEntities db = new DB_POSEntities())
            {
                string DB = db.Database.Connection.Database;
                string sqlCommand = "USE[master] RESTORE DATABASE[{0}] FROM DISK = N'{1}' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5";
                string sqlCommand1 = "USE[master] ALTER DATABASE [{0}] SET Single_User WITH Rollback Immediate";
                string sqlCommand2 = "USE[master] ALTER DATABASE [{0}] SET Multi_User";

                db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand1, DB));
                db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, DB, p_direccion));
                db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand2, DB));

                return true;
            }
            //}
            //catch
            //{
            //return false;
            //}
        }

    }
}
