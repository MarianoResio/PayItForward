using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PayItForward.Models
{
    public class Usuarios
    {
        private int _IdUsuario;
        private string _Nombre;
        private string _Apellido;
        private string _Mail;
        private string _Contrasena;
        private string _Imagen;
        private int _Puntos;
        private int _IDimagen;
        private bool _Especial;

        public Usuarios(bool especial, int IdUsuario, string Nombre, string Apellido, string Mail, string Contrasena, string Imagen, int Puntos, int idimagen)
        {
            _IdUsuario = IdUsuario;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Mail = Mail;
            _Contrasena = Contrasena;
            _Imagen = Imagen;
            _Puntos = Puntos;
            _IDimagen = idimagen;
            _Especial = especial;
        }

        public Usuarios() { }

        [Required(ErrorMessage = "*")]
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        [Required(ErrorMessage = "*")]
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        [Required(ErrorMessage = "*")]
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        [Required(ErrorMessage = "*")]
        public string Mail { get => _Mail; set => _Mail = value; }
        [Required(ErrorMessage = "*")]
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
        [Required(ErrorMessage = "*")]
        public string Imagen { get => _Imagen; set => _Imagen = value; }
        [Required(ErrorMessage = "*")]
        public int Puntos { get => _Puntos; set => _Puntos = value; }
        [Required(ErrorMessage = "*")]
        public int IDimagen { get => _IDimagen; set => _IDimagen = value; }
        [Required(ErrorMessage = "*")]
        public bool Especial { get => _Especial; set => _Especial = value; }
    }
}