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
        private bool _Aprobada;
        private int _Valor;
        private string _Titulo;
        private string _Descripcion;
        private int _Likes;
        private string _Ubicacion;
        private List<string> _NombreImagen;
        private HttpPostedFileBase[] _Imagenes;
        private bool _Destacada;

        [Required(ErrorMessage = "*")]
        public int IdPublicacion { get => _IdPublicacion; set => _IdPublicacion = value; }
        [Required(ErrorMessage = "*")]
        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        [Required(ErrorMessage = "*")]
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
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
        public List<string> NombreImagen { get => _NombreImagen; set => _NombreImagen = value; }
        public HttpPostedFileBase[] Imagenes { get => _Imagenes; set => _Imagenes = value; }
        public bool Destacada { get => _Destacada; set => _Destacada = value; }

        public Publicacion(int idPublicacion, int idCategoria, int idUsuario, List<string> nomImg, bool aprobada, int valor, string titulo, string descripcion, int likes, string ubicacion, bool destacada)
        {
            _IdPublicacion = idPublicacion;
            _IdCategoria = idCategoria;
            _IdUsuario = idUsuario;
            _NombreImagen = nomImg;
            _Aprobada = aprobada;
            _Valor = valor;
            _Titulo = titulo;
            _Descripcion = descripcion;
            _Likes = likes;
            _Ubicacion = ubicacion;
            _Destacada = destacada;
        }

        public Publicacion(int idPublicacion, int idCategoria, int idUsuario, List<string> nomImg, bool aprobada, int valor, string titulo, string descripcion, int likes, string ubicacion, HttpPostedFileBase[] imagenes, bool destacada)
        {
            _IdPublicacion = idPublicacion;
            _IdCategoria = idCategoria;
            _IdUsuario = idUsuario;
            _NombreImagen = nomImg;
            _Aprobada = aprobada;
            _Valor = valor;
            _Titulo = titulo;
            _Descripcion = descripcion;
            _Likes = likes;
            _Ubicacion = ubicacion;
            _Imagenes = imagenes;
            _Destacada = destacada;
        }

        public Publicacion()
        {
            Likes = 0;
            Aprobada = false;
        }
    }
}