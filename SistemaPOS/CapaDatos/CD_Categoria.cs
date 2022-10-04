using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Categoria
    {
         public void agregarCategoria(int pCodigo, string pdescripcion, int pEstado)
         {
             using (DB_POSEntities db = new DB_POSEntities())
             {
                    Categoria nuevaCategoria = new Categoria();

                    nuevaCategoria.codCategoria = pCodigo;
                    nuevaCategoria.descripcion = pdescripcion;
                    nuevaCategoria.estado = pEstado;
                    nuevaCategoria.fechaAlta = DateTime.Now;


                    db.Categoria.Add(nuevaCategoria);
                    db.SaveChanges();
             }
         }
    }
}
