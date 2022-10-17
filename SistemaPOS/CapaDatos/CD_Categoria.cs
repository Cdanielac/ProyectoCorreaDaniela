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

        public List<Object> Listar()
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                IQueryable<Object> oCategoria = from Categoria in db.Categoria
                                                select new
                                                {
                                                    //idCategoria = Categoria.idCategoria,
                                                    CODIGO = Categoria.codCategoria,
                                                    NOMBRE = Categoria.descripcion,
                                                    ESTADO = (Categoria.estado == 1 ? "Activo" : "Inactivo")
                                                };
                return oCategoria.ToList();
            }


        }

        public List<Categoria> ListaCategoria()
        {


            using (DB_POSEntities db = new DB_POSEntities())
            {
                List<Categoria> oCategoria = db.Categoria.ToList();

                return oCategoria;
            }


        }

        public Categoria UnaCategoria(int pCodigo)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                try
                {
                    Categoria categoriaActual = db.Categoria.Where(s => s.codCategoria == pCodigo).First();
                    return categoriaActual;
                }
                catch
                {
                    return null;
                }
            }


        }

        public Boolean CategoriaExiste(int pCodigo)
        {
            using (DB_POSEntities db = new DB_POSEntities())
            {
                Boolean categoriaExiste = false;
                List<Categoria> listaCategoria = ListaCategoria();

                foreach (var UnProveedor in listaCategoria)
                {
                    if (pCodigo == UnProveedor.codCategoria)
                    {
                        categoriaExiste = true;
                    }
                }

                return categoriaExiste;
            }

        }
    }
}
