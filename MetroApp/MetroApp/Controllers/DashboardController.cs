using System.Collections.Generic;
using System.Web.Mvc;

namespace MetroApp.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dashboard/VerTodasLasTarjetas
        public ActionResult VerTodasLasTarjetas()
        {
            // Simulamos una lista de tarjetas para mostrar en la vista
            var tarjetas = new List<object>
            {
                new { Numero = "1234", Tipo = "MasterCard" },
                new { Numero = "5678", Tipo = "Visa" }
                // Aquí puedes agregar más tarjetas según sea necesario
            };

            // Pasamos la lista de tarjetas a la vista
            ViewBag.Tarjetas = tarjetas;

            return View();
        }
    }
}
