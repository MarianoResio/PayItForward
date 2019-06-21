using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayItForward.Models
{
    public class Publicacion
    {
        private int _IdPublicacion;
        private int _IdCategoria;
        private int _IdUsuario;
        private bool _Aprobada;
        private int _Valor;
        private string _Titulo;
        private string _Descripcion;
        private int _Likes;
        private string _Ubicacion;

        public int IdPublicacion { get => _IdPublicacion; set => _IdPublicacion = value; }
        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public bool Aprobada { get => _Aprobada; set => _Aprobada = value; }
        public int Valor { get => _Valor; set => _Valor = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Likes { get => _Likes; set => _Likes = value; }
        public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }

        public Publicacion(int idPublicacion, int idCategoria, int idUsuario, bool aprobada, int valor, string titulo, string descripcion, int likes, string ubicacion)
        {
            _IdPublicacion = idPublicacion;
            _IdCategoria = idCategoria;
            _IdUsuario = idUsuario;
            _Aprobada = aprobada;
            _Valor = valor;
            _Titulo = titulo;
            _Descripcion = descripcion;
            _Likes = likes;
            _Ubicacion = ubicacion;
        }

        public Publicacion()
        {
            Likes = 0;
            Aprobada = false;
        }

       
    }
}