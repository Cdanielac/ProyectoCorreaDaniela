using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_FormaPago
    {
        public List<FormaPago> ListaFormaPago()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<FormaPago> oFormaPago = db.FormaPago.ToList();

                return oFormaPago;
            }


        }
    }
}
