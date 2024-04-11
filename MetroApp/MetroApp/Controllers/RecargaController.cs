using System;
using System.Web.Mvc;
using MetroApp.DataLayer.Models;

namespace MetroApp.Controllers
{
    public class RecargaController : Controller
    {
        public ActionResult Recargar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Recargar(Recarga recarga)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction("ConfirmacionRecarga");
            }

            return View(recarga);
        }

        public ActionResult ConfirmacionRecarga()
        {
            return View();
        }
    }
}
