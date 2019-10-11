using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayItForward.Models;

namespace PayItForward.Controllers
{
    public class VentaController : Controller
    {
        Conexion mIConexion = new Conexion();
        // GET: Venta
        public ActionResult Index()
        {
            List<Publicacion> ListaPublicaciones = new List<Publicacion>();
            ListaPublicaciones = mIConexion.TraerTodxsLxsPublicacionos();
            ViewBag.Publicaciones = ListaPublicaciones;
            return View();
        }
    }
}