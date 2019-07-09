using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayItForward.Models;

namespace PayItForward.Controllers
{
    public class Crear_PublicacionController : Controller
    {
        // GET: Crear_Publicacion
        Conexion miConexion = new Conexion();

        public ActionResult Index()
        {
            //traigo las categorias padre y las meto en un ViewBag
            List<Categorias> ListaCategoriasPadre = new List<Categorias>();
            ListaCategoriasPadre = miConexion.TraerCategoriasPadres();
            ViewBag.Lista = ListaCategoriasPadre;

            return View();
        }

        public ActionResult Productos()
        {
            //busco las categorias hijas de la categoria padre Productos (Id=1) y las meto en un ViewBag
            List<Categorias> ListaHijas = new List<Categorias>();
            ListaHijas = miConexion.TraerCategoriasHijas(1);
            ViewBag.CategoriasHijas = ListaHijas;

            return View("CategoriasHijas");
        }

        public ActionResult Servicios()
        {
            //busco las categorias hijas de la categoria padre Servicios (Id=2) y las meto en un ViewBag
            List<Categorias> ListaHijas = new List<Categorias>();
            ListaHijas = miConexion.TraerCategoriasHijas(2);
            ViewBag.CategoriasHijas = ListaHijas;

            return View("CategoriasHijas");
        }

        public JsonResult TraerHijas(int idPadre)
        {
            //funcion llamada por ajax
            //devuelvo un array con objetos (categorias) en forma de JSON con las categorias hijas de la categoria padre seleccionada por el usuario
            List<Categorias> cates = miConexion.TraerCategoriasHijas(idPadre);
            var jsonData = Json(cates, JsonRequestBehavior.AllowGet);
            return jsonData;
        }

        //REHACER
        [HttpPost]
        public ActionResult DescripcionPublicacion(int IdCategoria)
        {
            Session["IdCategoria"] = IdCategoria;

            return View();
        }

        //REHACER
        [HttpPost]
        public ActionResult MostrarPublicacion(Publicacion Publi)
        {
            Publi.IdCategoria = Convert.ToInt32(Session["IdCategoria"]);
            int UltimaPublicacion = miConexion.CrearPublicacion(Publi);
            ViewBag.Publicacion = Publi;
            //miConexion.AltaImagenPorPublicacion(UltimaPublicacion, Publi.Imagen);

            return View();
        }
    }
}