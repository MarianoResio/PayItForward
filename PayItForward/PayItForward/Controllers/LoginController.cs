﻿using System;
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
        public ActionResult ValidarLogin(string mail, string pass)
        {
            Usuarios user = new Usuarios();
            string password = Encriptar.Crypto(pass);
            user = miConexion.Login(mail, password);

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
                return View("Registro", user);
            }
            else
            {
                Session["UserNow"] = user;
                user.Especial = miConexion.ValidarUsuarioEspecialPorCodigo(codigo);
                if (user.Especial == false)
                {
                    ViewBag.Mensaje = "El codigo de superusuario es incorrecto";
                    return View("Registro", "Login");
                }
                else
                {
                    miConexion.borrarCodigoEspecial(codigo);
                }
                switch (user.IDimagen)
                {
                    case 1:
                        user.Imagen = "azul.png";
                        break;
                    case 2:
                        user.Imagen = "verde.png";
                        break;
                    case 3:
                        user.Imagen = "rojo.png";
                        break;
                }
                user.Contrasena = Encriptar.Crypto(user.Contrasena);
                miConexion.altaUsuario(user);
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session["UserNow"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}