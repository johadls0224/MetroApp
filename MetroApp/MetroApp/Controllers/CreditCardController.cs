using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroApp.Controllers
{
    public class CreditCardController : Controller
    {      
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string cardNumber, string cardType)
        {
    
            ViewBag.Message = "Tarjeta agregada exitosamente";
            return View();
        }
    }
}
