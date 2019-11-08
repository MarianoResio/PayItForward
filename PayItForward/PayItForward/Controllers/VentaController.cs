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
            if (Session["UserNow"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
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

        public ActionResult BusquedaTexto(string texto)
        {
            if (Session["UserNow"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                List<Publicacion> publicaciones = new List<Publicacion>();
                publicaciones = mIConexion.BusquedaPublicacionesPorTexto(texto);
                if (publicaciones != null)
                {
                    if (publicaciones[0].Titulo == "")
                    {
                        return View("Index");
                    }
                    else
                    {
                        List<string> listaImagenes = new List<string>();
                        foreach (Publicacion publi in publicaciones)
                        {
                            listaImagenes.Add("~/Content/ImagenesPublicaciones/" + publi.IdPublicacion + "_" + publi.NombreImagen[0]);
                        }

                        ViewBag.imagenesPublicacion = listaImagenes;
                        ViewBag.publicaciones = publicaciones;
                        return View("Resultadosbusqueda");
                    }
                }
                else
                {
                    return View("Index");
                }
            }
        }

        public ActionResult Comprar(int id)
        {
            Publicacion publicacion = new Publicacion();
            publicacion = mIConexion.TraerPublicacionPorId(id);
            Usuarios user = new Usuarios();
            user = mIConexion.traerUsuarioPorId(Convert.ToInt32(Session["IdUsuario"]));
            if (user.Especial == true)
            {
                mIConexion.ObtenerPublicacionEspecial(id, user.IdUsuario);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (user.Puntos >= publicacion.Valor)
                {
                    mIConexion.ObtenerPublicacionNoEspecial(id, user.IdUsuario, publicacion.IdUsuario);
                    return RedirectToAction("Index", "Home");
                } else
                {
                    ViewBag.Mensaje = "No contas con puntos suficientes para obtener esta publicacion";
                    return View("Index");
                }
            }
        }
    }
}