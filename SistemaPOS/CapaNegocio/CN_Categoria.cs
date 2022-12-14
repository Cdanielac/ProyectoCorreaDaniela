using CapaDatos;
using CapaDatos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        CD_Categoria categorias = new CD_Categoria();
        public void agregarCategoria(long pCodigo, string pdescripcion, int pEstado)
        {
            categorias.agregarCategoria(pCodigo, pdescripcion, pEstado);
        }

        public void editarCategoria(long pCodigo, string pdescripcion, int pEstado)
        {
            categorias.editarCategoria(pCodigo,pdescripcion,pEstado);
        }

        public List<Object> Listar()
        {
            return categorias.Listar();

        }

        public List<Categoria> ListaCategoria()
        {
            return categorias.ListaCategoria();

        }

        public Categoria UnaCategoria(long pCodigo)
        {
            return categorias.UnaCategoria(pCodigo);

        }

        public Categoria UnaCategoriaCod(long pCodigo)
        {
            return categorias.UnaCategoria(pCodigo);

        }

        public Categoria UnaCategoriaDesc(string pDesc)
        {
            return categorias.UnaCategoriaDesc(pDesc);
        }

        public Boolean CategoriaExiste(long pCodigo)
        {
            return categorias.CategoriaExiste(pCodigo);

        }


    }
}

