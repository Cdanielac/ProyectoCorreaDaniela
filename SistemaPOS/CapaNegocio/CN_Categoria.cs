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
        public void agregarCategoria(int pCodigo, string pdescripcion, int pEstado)
        {
            categorias.agregarCategoria(pCodigo, pdescripcion, pEstado);
        }

        public void editarCategoria(int pCodigo, string pdescripcion, int pEstado)
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

        public Categoria UnaCategoria(int pCodigo)
        {
            return categorias.UnaCategoria(pCodigo);

        }

        public Categoria UnaCategoriaCod(int pCodigo)
        {
            return categorias.UnaCategoria(pCodigo);

        }

        public Boolean CategoriaExiste(int pCodigo)
        {
            return categorias.CategoriaExiste(pCodigo);

        }


    }
}

