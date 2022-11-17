using CapaDatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reportes
    {
        CD_Reportes reportes = new CD_Reportes();
        public List<int> ventasPorFechaP(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            return reportes.ventasPorFechaP(pFechaDesde,pFechaHasta);

        }

        public List<decimal> ventasPorFechaS(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            return reportes.ventasPorFechaS(pFechaDesde, pFechaHasta);

        }

        public List<decimal> ventasPorFechaCajeroT(DateTime pFechaDesde, DateTime pFechaHasta, int pIdCajero)
        {
            return reportes.ventasPorFechaCajeroT(pFechaDesde,pFechaHasta,pIdCajero);
        }

        public List<int> ventasPorFechaCajeroV(DateTime pFechaDesde, DateTime pFechaHasta, int pIdCajero)
        {

            return reportes.ventasPorFechaCajeroV(pFechaDesde,pFechaHasta,pIdCajero);
        }

        public List<string> acumuladoPorCajero()
        {

            return reportes.acumuladoPorCajero();
        }

        public List<decimal> acumuladoPorCajeroA()
        {

            return reportes.acumuladoPorCajeroA();
        }

        public List<decimal> acumuladoPorCategoriaA()
        {

           return reportes.acumuladoPorCategoriaA();
        }

        public List<string> acumuladoPorCategoria()
        {

            return reportes.acumuladoPorCategoria();
        }

        public List<string> acumuladoPorMes(DateTime pYear)
        {
            return reportes.acumuladoPorMes(pYear);
        }

        public List<decimal> acumuladoPorMesA(DateTime pYear)
        {
            return reportes.acumuladoPorMesA(pYear);
        }

        public List<string> productosMasVendidos(int pMes)
        {

            return reportes.productosMasVendidos(pMes);
        }

        public List<int> productosMasVendidosC(int pMes)
        {

            return reportes.productosMasVendidosC(pMes);
        }

        public List<string> stockMinimo()
        {
            return reportes.stockMinimo();
        }

        public List<int> stockMinimoS()
        {

            return reportes.stockMinimoS();
        }
    }
}
