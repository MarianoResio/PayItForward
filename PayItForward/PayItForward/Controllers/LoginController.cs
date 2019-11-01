using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayItForward.Models;

namespace PayItForward.Controllers
{
    public class LoginController : Controller
    {
        Conexion miConexion = new Conexion();
        Encriptar Encriptar = new Encriptar();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidarLogin(Usuarios user)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");
            }
            else
            {
                user.Nombre = "";
                user.Apellido = "";
                user.IDimagen = 1;
                user.Puntos = 0;
                user.Imagen = "";
                user.Contrasena = Encriptar.Crypto(user.Contrasena);
                user = miConexion.Login(user.Mail, user.Contrasena);
                if (user != null)
                {
                    Session["UserNow"] = user;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.UserNotFound = "No existe ese usuario";
                    return View("Login");
                }
            }
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidarRegistro(Usuarios user, string codigo)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "error";
                return View("Registro");
            }
            else
            {
                Session["UserNow"] = user;
                user.Especial = miConexion.ValidarUsuarioEspecialPorCodigo(codigo);
                switch (user.IDimagen) {
                    case 1:
                        user.Imagen = "azul";
                        break;
                    case 2:
                        user.Imagen = "verde";
                        break;
                    case 3:
                        user.Imagen = "rojo";
                        break;
                }
                user.Contrasena = Encriptar.Crypto(user.Contrasena);
                miConexion.altaUsuario(user);
                miConexion.borrarCodigoEspecial(codigo);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}