using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public Usuarios(int IdUsuario, string Nombre, string Apellido, string Mail, string Contrasena, string Imagen, int Puntos)
        {
            _IdUsuario = IdUsuario;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Mail = Mail;
            _Contrasena = Contrasena;
            _Imagen = Imagen;
            _Puntos = Puntos;
        }

        public Usuarios() { }

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
        public string Imagen { get => _Imagen; set => _Imagen = value; }
        public int Puntos { get => _Puntos; set => _Puntos = value; }
    }
}