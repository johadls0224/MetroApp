using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroApp.Controllers
{
    public class VerTodasLasTarjetasController : Controller
    {
        // GET: VerTodasLasTarjetas
        public ActionResult Index()
        {
            return View();
        }

        // GET: VerTodasLasTarjetas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VerTodasLasTarjetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VerTodasLasTarjetas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VerTodasLasTarjetas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VerTodasLasTarjetas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VerTodasLasTarjetas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VerTodasLasTarjetas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}