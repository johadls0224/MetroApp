using MetroApp.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroApp.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Index()
        {
            string Cedula = Session["Cedula"].ToString();

            try
            {
                using (MetroAppContext db = new MetroAppContext())
                {
                    var usuario = db.Usuarios.FirstOrDefault(u => u.Cedula == Cedula);

                    if (usuario != null)
                    {
                        string nombreUsuario = usuario.Nombre;

                        Session["UserName"] = nombreUsuario;

                        var tarjeta = db.TarjetaMetro.FirstOrDefault(t => t.Cedula == Cedula);

                        if (tarjeta != null)
                        {
                            double saldo = tarjeta.Saldo;

                            Session["SaldoTarjeta"] = saldo;

                            var numerotarjeta = db.TarjetaPagos.FirstOrDefault(t => t.Cedula == Cedula);

                            if (numerotarjeta != null)
                            {
                                string NumeroTarjeta = numerotarjeta.NumeroTarjeta.ToString();
                                Session["NumeroTarjeta"] = numerotarjeta;
                            }
                            else
                            {
                                ViewBag.error = "No hay numero de tarjeta asociado con la cuenta";
                                return View();
                            }
                        }
                        else
                        {
                            ViewBag.error = "No se encontró una tarjeta asociada a este usuario, por favor ingresar una para poder visualizarla.";
                            return View();
                        }

                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        ViewBag.error = "Por favor recargue, usuario no encontrado.";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View(ex);
            }
        }
    }

}