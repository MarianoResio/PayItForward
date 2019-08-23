using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PayItForward.Models
{
    public class Publicacion
    {
        private int _IdPublicacion;
        private int _IdCategoria;
        private int _IdUsuario;
        private string _Imagen1;
        private string _Imagen2;
        private string _Imagen3;
        private bool _Aprobada;
        private int _Valor;
        private string _Titulo;
        private string _Descripcion;
        private int _Likes;
        private string _Ubicacion;

        [Required(ErrorMessage = "*")]
        public int IdPublicacion { get => _IdPublicacion; set => _IdPublicacion = value; }
        [Required(ErrorMessage = "*")]
        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        [Required(ErrorMessage = "*")]
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        [Required(ErrorMessage = "*")]
        public string Imagen1 { get => _Imagen1; set => _Imagen1 = value; }
        [Required(ErrorMessage = "*")]
        public string Imagen2 { get => _Imagen2; set => _Imagen2 = value; }
        [Required(ErrorMessage = "*")]
        public string Imagen3 { get => _Imagen3; set => _Imagen3 = value; }
        [Required(ErrorMessage = "*")]
        public bool Aprobada { get => _Aprobada; set => _Aprobada = value; }
        [Required(ErrorMessage = "*"), Range(1, int.MaxValue)]
        public int Valor { get => _Valor; set => _Valor = value; }
        [Required(ErrorMessage = "*")]
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        [Required(ErrorMessage = "*")]
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        [Required(ErrorMessage = "*")]
        public int Likes { get => _Likes; set => _Likes = value; }
        [Required(ErrorMessage = "*")]
        public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }

        public Publicacion(int idPublicacion, int idCategoria, int idUsuario, string img1, string img2, string img3, bool aprobada, int valor, string titulo, string descripcion, int likes, string ubicacion)
        {
            _IdPublicacion = idPublicacion;
            _IdCategoria = idCategoria;
            _IdUsuario = idUsuario;
            _Imagen1 = img1;
            _Imagen2 = img2;
            _Imagen3 = img3;
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