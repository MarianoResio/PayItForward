using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayItForward.Models;

namespace PayItForward.Controllers
{
    public class BMPublicacionesController : Controller
    {
        Conexion miConexion = new Conexion();

        // GET: BMPublicaciones
        public ActionResult VerPublicaciones()
        {
            List<Publicacion> ListaPublicaciones = new List<Publicacion>();
            ListaPublicaciones = miConexion.TraerPublicacionesPorUsuario(Convert.ToInt32(Session["IdUsuario"]));


            ViewBag.Lista = ListaPublicaciones;
            return View();
        }

        public ActionResult BMPublicacion(string Accion, int Id)
        {
            if (Accion == "Eliminar")
            {
                miConexion.EliminarPublicacion(Id);
            }
            else if (Accion == "Modificar" || Accion == "Ver")
            {
                Publicacion X = miConexion.TraerPublicacionPorId(Id);
                ViewBag.Accion = Accion;

                return View(X);
            }
            return RedirectToAction("VerPublicaciones");
        }
    }
}