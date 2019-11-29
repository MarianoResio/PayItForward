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
                int z = 0;
                do
                {
                    int IdUser = Convert.ToInt32(Session["IdUsuario"]);
                    if (ListaPublicaciones[z].IdUsuario == IdUser)
                    {
                        ListaPublicaciones.Remove(ListaPublicaciones[z]);
                        z--;
                    }
                    z++;
                } while (ListaPublicaciones.Count() > z);

                ViewBag.Publicaciones = ListaPublicaciones;
                List<string> listaImagenes = new List<string>();

                int contImg = 1;

                foreach (Publicacion Publi in ListaPublicaciones)
                {
                    foreach (String nombreImagen in Publi.NombreImagen)
                    {
                        if(contImg==1)
                        {
                            listaImagenes.Add("~/Content/ImagenesPublicaciones/" + Publi.IdPublicacion + "_" + nombreImagen);
                        }
                        contImg++;
                    }
                    contImg = 1;
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
                mIConexion.ObtenerPublicacionEspecial(id, publicacion.IdUsuario);
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
                    List<Publicacion> ListaPublicaciones = new List<Publicacion>();
                    ListaPublicaciones = mIConexion.TraerTodxsLxsPublicacionos();
                    ViewBag.Publicaciones = ListaPublicaciones;
                    List<string> listaImagenes = new List<string>();

                    int contImg = 1;

                    foreach (Publicacion Publi in ListaPublicaciones)
                    {
                        foreach (String nombreImagen in Publi.NombreImagen)
                        {
                            if (contImg == 1)
                            {
                                listaImagenes.Add("~/Content/ImagenesPublicaciones/" + Publi.IdPublicacion + "_" + nombreImagen);
                            }
                            contImg++;
                        }
                        contImg = 1;
                    }
                    ViewBag.imagenesPublicacion = listaImagenes;
                    return View("Index");
                }
            }
        }

        public ActionResult BusquedaCategorias()
        {
            return View();
        }

        public JsonResult TraerHijas(string nombrePadre)
        {
            //funcion llamada por ajax
            //devuelvo un array con objetos (categorias) en forma de JSON con las categorias hijas de la categoria padre seleccionada por el usuario
            List<Categorias> cates = mIConexion.TraerCategoriasHijasPorNombre(nombrePadre);
            var jsonData = Json(cates, JsonRequestBehavior.AllowGet);
            return jsonData;
        }

        public JsonResult TraerPublicacionesBusquedaCategoria(string nombrePadre)
        {
            //funcion llamada por ajax
            //devuelvo un array con objetos (publicaciones) en forma de JSON de la categorias hija seleccionada por el usuario
            List<Publicacion> pub = mIConexion.TraerPublicacionesBusquedaCategoria(nombrePadre);
            List<Publicacion> pub2 = mIConexion.TraerPublicacionesPorIdCategoria(mIConexion.traerIDCategoriaPorNombre(nombrePadre));
            foreach(Publicacion X in pub2)
            {
                pub.Add(X);
            }
            var jsonData = Json(pub, JsonRequestBehavior.AllowGet);
            return jsonData;
        }
    }
}