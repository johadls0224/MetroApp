using MetroApp.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Cedula, string Password)
        {
            try
            {
                using (MetroAppContext db = new MetroAppContext())
                {
                    var login = db.Usuarios.Where(x => x.Cedula == Cedula && x.Password == Password).FirstOrDefault();
                    if (login != null)
                    {
                        Session["UserName"] = (login.Nombre);
                        Session["UserName"] = (login.Apellido);
                        Session["Cedula"] = Cedula;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.error = "Cedula y/o contraseña invalida";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}