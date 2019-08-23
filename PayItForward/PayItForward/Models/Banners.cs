using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayItForward.Models
{
    public class Banners
    {
        private int idBanner;
        private DateTime hasta;
        private string imagen;

        public int IdBanner { get => idBanner; set => idBanner = value; }
        public DateTime Hasta { get => hasta; set => hasta = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        public Banners()
        {

        }

        public Banners(int idBanner, DateTime hasta, string imagen)
        {
            this.idBanner = idBanner;
            this.hasta = hasta;
            this.imagen = imagen;
        }
    }
}