using System;
using System.Web.Mvc;
using MetroApp.DataLayer.Models; // Asegúrate de importar tu modelo aquí

public class TarjetaController : Controller
{
    // GET: Tarjeta/Registrar
    public ActionResult agregartarjeta()
    {
        return View();
    }

    // POST: Tarjeta/Registrar
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult agregartarjeta(TarjetaPagos model)
    {
        if (ModelState.IsValid)
        {
            // Aquí puedes agregar la lógica para guardar la tarjeta en la base de datos
            // Por ejemplo:
            // tuDbContext.TuTabla.Add(model);
            // tuDbContext.SaveChanges();

            // Redirigir al usuario a alguna página de éxito
            return RedirectToAction("Index", "Dashboard");
        }

        // Si el modelo no es válido, volver a mostrar el formulario con los mensajes de validación
        return View(model);
    }
}
