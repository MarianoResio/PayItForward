using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayItForward.Models;

namespace PayItForward.Controllers
{
    public class HomeController : Controller
    {
        Conexion miConexion = new Conexion();

        public ActionResult Index()
        {
            List<Banners> Lista = new List<Banners>();
            Lista = miConexion.TraerBanners();
            ViewBag.Banners = Lista;
            ViewBag.Contador = 0;
            return View();
        }
    }
}