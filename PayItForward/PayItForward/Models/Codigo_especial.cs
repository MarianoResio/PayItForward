using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayItForward.Models
{
    public class Codigo_especial
    {
        private string _Codigo;

        public Codigo_especial()
        {

        }

        public Codigo_especial(string Codigo)
        {
            _Codigo = Codigo;
        }

        public string Codigo { get => _Codigo; set => _Codigo = value; }
    }
}