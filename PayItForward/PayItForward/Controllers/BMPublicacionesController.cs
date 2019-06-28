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
            Categorias hijas = new Categorias();

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
                /*
                Categorias categoria = miConexion.TraerCategoriaPorID(Id);
                ViewBag.publicacion.titulo = X.Titulo;
                ViewBag.publicacion.categoria = categoria;
                ViewBag.publicacion.idUsuario = X.IdUsuario; //cambiar por el nombre del usuario
                ViewBag.publicacion.aprobada = X.Aprobada;
                ViewBag.publicacion.valor = X.Valor;
                ViewBag.publicacion.descripcion = X.Descripcion;
                ViewBag.publicacion.likes = X.Likes;
                ViewBag.publicacion.ubicacion = X.Ubicacion;*/

                return View();
            }
            return RedirectToAction("VerPublicaciones");
        }
    }
}