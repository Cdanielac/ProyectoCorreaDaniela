﻿using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_TipoFactura
    {
        public List<TipoFactura> ListaTipoFactura()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<TipoFactura> oTipoFactura = db.TipoFactura.ToList();

                return oTipoFactura;
            }


        }
    }
}
