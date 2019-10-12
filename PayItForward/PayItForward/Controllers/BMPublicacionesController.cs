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
            //traigo las publicaciones del usuario actual y las pongo en un ViewBag
            ListaPublicaciones = miConexion.TraerPublicacionesPorUsuario(0); //0=Session["UserNow"]
            ViewBag.Lista = ListaPublicaciones;

            return View();
        }

        public ActionResult BMPublicacion(string Accion, int Id)
        {
            if (Accion == "Eliminar")
            {
                //elimino la publicacion
                miConexion.EliminarPublicacion(Id);
            }
            else if (Accion == "Modificar" || Accion == "Ver")
            {
                //traigo la publicacion seleccionada en la View "VerPublicaciones"
                Publicacion X = miConexion.TraerPublicacionPorId(Id);
                ViewBag.Accion = Accion;

                List<string> listaImagenes = new List<string>();
                foreach (HttpPostedFileBase x in X.Imagenes)
                {
                    listaImagenes.Add("~/Content/ImagenesPublicaciones/" + X.IdPublicacion + "_" + x.FileName);
                }
                ViewBag.imagenesPublicacion = listaImagenes;

                return View(X);
            }
            return RedirectToAction("VerPublicaciones");
        }

        public ActionResult editarPublicacion(Publicacion x)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CategoriaActual = x.IdCategoria;
                ViewBag.Accion = "Modificar";
                return View("BMPublicacion", x);
            }
            else
            {

                miConexion.ModificarPublicacion(x);
                foreach (HttpPostedFileBase img in x.Imagenes)
                {
                    if (img != null)
                    {
                        string NuevaUbicacion = Server.MapPath("~/Content/ImagenesPublicaciones/") + x.IdPublicacion + "_" + img.FileName;
                        img.SaveAs(NuevaUbicacion);
                    }
                }
                return RedirectToAction("VerPublicaciones");
            }
        }
    }
}