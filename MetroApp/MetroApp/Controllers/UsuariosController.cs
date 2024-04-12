using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MetroApp.DataLayer.Context;
using MetroApp.DataLayer.Models;

namespace MetroApp.Controllers
{
    public class UsuariosController : Controller
    {
        private MetroAppContext db = new MetroAppContext();

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cedula,TipoDocumento,Nombre,Apellido,Email,Password,Telefono,FechaRegistro,EstadoUsuario")] Usuarios usuarios)
        {
            try
            {
                TarjetaMetro tarjetaMetro = new TarjetaMetro();
                tarjetaMetro.Saldo = 100;
                tarjetaMetro.Cedula = usuarios.Cedula;

                if (ModelState.IsValid)
                {
                    usuarios.FechaRegistro = DateTime.Now;
                    usuarios.EstadoUsuario = true;
                    db.Usuarios.Add(usuarios); // Creacion de usuarios
                    db.TarjetaMetro.Add(tarjetaMetro); // Se crea nueva tarjeta de metro
                    db.SaveChanges();
                    return RedirectToAction("Login", "Login");
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return View(usuarios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
