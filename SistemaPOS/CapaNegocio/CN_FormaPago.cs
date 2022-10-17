using CapaDatos;
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
        CD_FormaPago formasPago = new CD_FormaPago();
        public List<FormaPago> ListaFormaPago()
        {
            return formasPago.ListaFormaPago().ToList();
        }
    }
}
