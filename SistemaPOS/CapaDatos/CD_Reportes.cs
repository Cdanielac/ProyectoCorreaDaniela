using CapaDatos.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reportes
    {

        public ArrayList ventasPorFecha(DateTime pFechaDesde, DateTime pFechaHasta)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<string> productos = new List<string>();
                List<decimal> subtotal = new List<decimal>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorFecha");
                cmd.Parameters.AddWithValue("@fechaDesde", pFechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", pFechaHasta);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    productos.Add(dr.GetString(0));
                    subtotal.Add(dr.GetDecimal(1));
                }

                cn.Close();

                ArrayList arrayList = new ArrayList();
                arrayList.Add(productos);
                arrayList.Add(subtotal);
                return arrayList;
            }
        }

        public List<int> ventasPorFechaP(DateTime pFechaDesde, DateTime pFechaHasta)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<int> nroVenta = new List<int>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorFecha");
                cmd.Parameters.AddWithValue("@fechaDesde", pFechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", pFechaHasta);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    nroVenta.Add(dr.GetInt32(0));
                }

                cn.Close();
                return nroVenta;
            }
        }


        public List<decimal> ventasPorFechaS(DateTime pFechaDesde, DateTime pFechaHasta)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<decimal> total = new List<decimal>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorFecha");
                cmd.Parameters.AddWithValue("@fechaDesde", pFechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", pFechaHasta);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    total.Add(dr.GetDecimal(1));
                }

                cn.Close();

                return total;
            }
        }

        public List<decimal> ventasPorFechaCajeroT(DateTime pFechaDesde, DateTime pFechaHasta, int pIdCajero)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<decimal> total = new List<decimal>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorFechaCajero");
                cmd.Parameters.AddWithValue("@fechaDesde", pFechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", pFechaHasta);
                cmd.Parameters.AddWithValue("@idCajero", pIdCajero);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    total.Add(dr.GetDecimal(1));
                }

                cn.Close();

                return total;
            }
        }

        public List<int> ventasPorFechaCajeroV(DateTime pFechaDesde, DateTime pFechaHasta, int pIdCajero)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<int> nroVenta = new List<int>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorFechaCajero");
                cmd.Parameters.AddWithValue("@fechaDesde", pFechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", pFechaHasta);
                cmd.Parameters.AddWithValue("@idCajero", pIdCajero);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    nroVenta.Add(dr.GetInt32(0));
                }

                cn.Close();

                return nroVenta;
            }
        }

        public List<string> acumuladoPorCajero()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<string> cajero = new List<string>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorCajero");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cajero.Add(dr.GetString(1));
                }

                cn.Close();

                return cajero;
            }
        }

        public List<decimal> acumuladoPorCajeroA()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<decimal> acumulado = new List<decimal>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorCajero");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    acumulado.Add(dr.GetDecimal(0));
                }

                cn.Close();

                return acumulado;
            }
        }

        public List<decimal> acumuladoPorCategoriaA()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<decimal> acumulado = new List<decimal>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorCategoria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    acumulado.Add(dr.GetDecimal(1));
                }

                cn.Close();

                return acumulado;
            }
        }

        public List<string> acumuladoPorCategoria()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<string> categoria = new List<string>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorCategoria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    categoria.Add(dr.GetString(0));
                }

                cn.Close();

                return categoria;
            }
        }

        public List<string> acumuladoPorMes(DateTime pYear)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<string> mes = new List<string>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorMes");
                cmd.Parameters.AddWithValue("@Year", pYear);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    mes.Add(dr.GetString(0));
                }

                cn.Close();

                return mes;
            }
        }

        public List<decimal> acumuladoPorMesA(DateTime pYear)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<decimal> acumulado = new List<decimal>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("ventasPorMes");
                cmd.Parameters.AddWithValue("@Year", pYear);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    acumulado.Add(dr.GetDecimal(1));
                }

                cn.Close();

                return acumulado;
            }
        }

        public List<string> productosMasVendidos(int pMes)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<string> producto = new List<string>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("productosMasVendidos");
                cmd.Parameters.AddWithValue("@Mes", pMes);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    producto.Add(dr.GetString(0));
                }

                cn.Close();

                return producto;
            }
        }

        public List<int> productosMasVendidosC(int pMes)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<int> cantidad = new List<int>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("productosMasVendidos");
                cmd.Parameters.AddWithValue("@Mes", pMes);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cantidad.Add(dr.GetInt32(1));
                }

                cn.Close();

                return cantidad;
            }
        }

        public List<string> stockMinimo()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<string> prod = new List<string>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("stockMinimo");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    prod.Add(dr.GetString(0));
                }

                cn.Close();

                return prod;
            }
        }

        public List<int> stockMinimoS()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<int> stock = new List<int>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("stockMinimo");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    stock.Add(dr.GetInt32(1));
                }

                cn.Close();

                return stock;
            }
        }

        public List<string> EmpleadoAntiguedad()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<string> empleado = new List<string>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("antiguedadEmpleados");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    empleado.Add(dr.GetString(0));
                }

                cn.Close();

                return empleado;
            }
        }


        public List<int> EmpleadoAntiguedadA()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<int> antiguedad = new List<int>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("antiguedadEmpleados");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    antiguedad.Add(dr.GetInt32(1));
                }

                cn.Close();

                return antiguedad;
            }
        }

        public List<string> UsuarioRol()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<string> usuario = new List<string>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("cantUsuariosRol");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuario.Add(dr.GetString(1));
                }

                cn.Close();

                return usuario;
            }
        }

        public List<int> UsuarioRolC()
        {

            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-C26D9LB;Initial Catalog=DB_POS;Integrated Security=True"))
            {
                List<int> cantidad = new List<int>();
                SqlDataReader dr;
                cn.Open();
                SqlCommand cmd = new SqlCommand("cantUsuariosRol");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cantidad.Add(dr.GetInt32(0));
                }

                cn.Close();

                return cantidad;
            }
        }
    }
}