using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayItForward.Models
{
    public class Categorias
    {
        public int IdCategoria;
        public int IdCategoriaPadre;
        public string Nombre;
        public string Imagen;

        public Categorias(int idCategoria, int idCategoriaPadre, string nombre, string imagen)
        {
            IdCategoria = idCategoria;
            IdCategoriaPadre = idCategoriaPadre;
            Nombre = nombre;
            Imagen = imagen;
        }

        public Categorias()
        {

        }
    }
}