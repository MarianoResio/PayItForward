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
            List<Categorias> ListaCategoriasPadre = new List<Categorias>();
            ListaCategoriasPadre = miConexion.TraerCategoriasPadres();
            ViewBag.Lista = ListaCategoriasPadre;

            return View();
        }

        public ActionResult Productos()
        {
            int CategoriaPadre = 1;
            List<Categorias> ListaHijas = new List<Categorias>();
            ListaHijas = miConexion.TraerCategoriasHijas(CategoriaPadre);
            ViewBag.CategoriasHijas_SubCat1 = ListaHijas;

            return View();
        }

        public ActionResult Servicios()
        {
            int CategoriaPadre = 2;
            List<Categorias> ListaHijas = new List<Categorias>();
            ListaHijas = miConexion.TraerCategoriasHijas(CategoriaPadre);
            ViewBag.CategoriasHijas_SubCat1 = ListaHijas;

            return View();
        }

        public ActionResult DescripcionPublicacion(int IdCategoria)
        {
            Session["IdCategoria"] = IdCategoria;

            return View();
        }
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