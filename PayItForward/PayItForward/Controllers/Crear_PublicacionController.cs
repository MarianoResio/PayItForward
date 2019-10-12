using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult DescripcionPublicacion(int IdCategoria)
        {
            //pongo en un ViewBag la categoria final seleccionada por el usuario
            ViewBag.CategoriaActual = IdCategoria;

            return View();
        }

        [HttpPost]
        public ActionResult MostrarPublicacion(Publicacion Publi, int IdCategoria)
        {

            Publi.IdCategoria = Convert.ToInt32(IdCategoria);
            if (!ModelState.IsValid)
            {
                ViewBag.CategoriaActual = IdCategoria;
                return View("DescripcionPublicacion", Publi);
            }
            else
            {
                // guardar las imagenes en content
                int UltimaPublicacion = miConexion.CrearPublicacion(Publi);

                if (Publi.Imagenes != null)
                {
                    Publi.NombreImagen = new List<string>();
                    foreach (HttpPostedFileBase img in Publi.Imagenes)
                    {
                        if (img != null)
                        {
                            string NuevaUbicacion = Server.MapPath("~/Content/ImagenesPublicaciones/") + UltimaPublicacion + "_" + img.FileName;
                            img.SaveAs(NuevaUbicacion);
                            Publi.NombreImagen.Add(img.FileName.ToString());
                        }
                    }
                }

                ViewBag.Publicacion = Publi;
                List<string> listaImagenes = new List<string>();
                foreach(HttpPostedFileBase x in Publi.Imagenes)
                {
                    listaImagenes.Add("~/Content/ImagenesPublicaciones/" + Publi.IdPublicacion + "_" + x.FileName);
                }
                ViewBag.imagenesPublicacion = listaImagenes;
                return View();
            }
        }
    }
}