using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayItForward.Models
{
    public class Banners
    {
        private int idBanner;
        private DateTime desde;
        private DateTime hasta;
        private string imagen;

        public int IdBanner { get => idBanner; set => idBanner = value; }
        public DateTime Desde { get => desde; set => desde = value; }
        public DateTime Hasta { get => hasta; set => hasta = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        public Banners()
        {

        }

        public Banners(int idBanner, DateTime desde, DateTime hasta, string imagen)
        {
            this.idBanner = idBanner;
            this.desde = desde;
            this.hasta = hasta;
            this.imagen = imagen;
        }
    }
}