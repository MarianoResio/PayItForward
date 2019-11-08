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
            if (Session["UserNow"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                List<Publicacion> ListaPublicaciones = new List<Publicacion>();
                //traigo las publicaciones del usuario actual y las pongo en un ViewBag
                ListaPublicaciones = miConexion.TraerPublicacionesPorUsuario(0); //0=Session["UserNow"]
                ViewBag.Lista = ListaPublicaciones;

                return View();
            }
        }

        public ActionResult BMPublicacion(string Accion, int Id)
        {
            if (Session["UserNow"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
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
                    foreach (String x in X.NombreImagen)
                    {
                        if (x != "")
                        {
                            listaImagenes.Add("~/Content/ImagenesPublicaciones/" + X.IdPublicacion + "_" + x);
                        }
                    }
                    ViewBag.imagenesPublicacion = listaImagenes;

                    return View(X);
                }
                return RedirectToAction("VerPublicaciones");
            }
        }


        public ActionResult editarPublicacion(Publicacion x)
        {
            if (Session["UserNow"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.CategoriaActual = x.IdCategoria;
                    ViewBag.Accion = "Modificar";
                    return View("BMPublicacion", x);
                }
                else
                {
                    if (x.Imagenes[0] == null)
                    {
                        Publicacion publi = new Publicacion();
                        publi = miConexion.TraerPublicacionPorId(x.IdPublicacion);

                        publi.Titulo = x.Titulo;
                        publi.Valor = x.Valor;
                        publi.Descripcion = x.Descripcion;
                        publi.Ubicacion = x.Ubicacion;
                        /*if (publi.NombreImagen[0] != "")
                        {
                            x.NombreImagen.Add
                        }
                        if (publi.NombreImagen[1] != "")
                        {
                            x.NombreImagen.Add(publi.NombreImagen[1]);
                        }
                        if (publi.NombreImagen[2] != "")
                        {
                            x.NombreImagen.Add(publi.NombreImagen[2]);
                        }*/
                        miConexion.ModificarPublicacionSinImagen(publi);
                        foreach (HttpPostedFileBase img in x.Imagenes)
                        {
                            if (img != null)
                            {
                                string NuevaUbicacion = Server.MapPath("~/Content/ImagenesPublicaciones/") + x.IdPublicacion + "_" + img.FileName;
                                img.SaveAs(NuevaUbicacion);
                            }
                        }
                    }
                    else
                    {
                        miConexion.ModificarPublicacionConImagen(x);
                        foreach (HttpPostedFileBase img in x.Imagenes)
                        {
                            if (img != null)
                            {
                                string NuevaUbicacion = Server.MapPath("~/Content/ImagenesPublicaciones/") + x.IdPublicacion + "_" + img.FileName;
                                img.SaveAs(NuevaUbicacion);
                            }
                        }
                    }

                    return RedirectToAction("VerPublicaciones");
                }
            }
        }
    }
}