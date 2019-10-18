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
            List<string> listaImagenes = new List<string>();

            foreach (Publicacion Publi in ListaPublicaciones)
            {
                foreach (String nombreImagen in Publi.NombreImagen)
                {
                    listaImagenes.Add("~/Content/ImagenesPublicaciones/" + Publi.IdPublicacion + "_" + nombreImagen);
                }
            }
            ViewBag.imagenesPublicacion = listaImagenes;
            return View();
        }
    }
}