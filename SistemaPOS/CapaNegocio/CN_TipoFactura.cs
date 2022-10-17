using CapaDatos;
using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_TipoFactura
    {
        CD_TipoFactura tiposFacturas = new CD_TipoFactura();
        public List<TipoFactura> ListaTipoFactura()
        {
            return tiposFacturas.ListaTipoFactura();                     

        }
    }
}
