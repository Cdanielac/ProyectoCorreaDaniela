using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using CapaDatos.Entity;

namespace CapaDatos
{
    public class CD_Conexion_DS
    {
        public static SqlConnection cnx = new SqlConnection("Data Source = DESKTOP - C26D9LB; Initial Catalog = DB_POS; Integrated Security = True");

        public bool EjecutarQuery(string SQL)
        {
            bool Respuesta = false;

            SqlCommand cmd = new SqlCommand(SQL, cnx);

            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                Respuesta = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();

            }

            return Respuesta;

        }
        public DataSet QueryConsultaDataSet(string Q)
        {
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(Q, cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                cnx.Open();
                da.Fill(ds);

                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }

            finally { cnx.Close(); }

            return ds;

        }
        public DataTable EjecutarConsulta(string SQL)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(SQL, cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                cnx.Open();
                da.Fill(dt);
                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnx.Close();

            }

            return dt;
        }

        public bool resguardarDatos(string pNombreResguardo, string pPath)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection("Data Source = DESKTOP - C26D9LB; Initial Catalog = DB_POS; Integrated Security = True"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("resguardar");
                    cmd.Parameters.AddWithValue("@nombre", pNombreResguardo);
                    cmd.Parameters.AddWithValue("@ubicacion", pPath);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
