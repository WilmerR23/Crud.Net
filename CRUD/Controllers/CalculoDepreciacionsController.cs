using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class CalculoDepreciacionsController : Controller
    {
        private Context db = new Context();

        // GET: CalculoDepreciacions
        public ActionResult Index()
        {
            var calculoDepreciacion = db.CalculoDepreciacion.Include(c => c.ActivoFijo);
            return View(calculoDepreciacion.ToList());
        }

        // GET: CalculoDepreciacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalculoDepreciacion calculoDepreciacion = db.CalculoDepreciacion.Find(id);
            if (calculoDepreciacion == null)
            {
                return HttpNotFound();
            }
            return View(calculoDepreciacion);
        }

        // GET: CalculoDepreciacions/Create
        public ActionResult Create()
        {
            ViewBag.ActivoFijoId = new SelectList(db.ActivoFijo, "Id", "Descripción");
            return View();
        }

        // POST: CalculoDepreciacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AñoProceso,MesProceso,ActivoFijoId,DepreciaciónAcumulada,CuentaCompra,CuentaDepreciación,MontoDepreciado,FechaProceso")] CalculoDepreciacion calculoDepreciacion)
        {
            if (ModelState.IsValid)
            {
                db.CalculoDepreciacion.Add(calculoDepreciacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActivoFijoId = new SelectList(db.ActivoFijo, "Id", "Descripción", calculoDepreciacion.ActivoFijoId);
            return View(calculoDepreciacion);
        }

        // GET: CalculoDepreciacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalculoDepreciacion calculoDepreciacion = db.CalculoDepreciacion.Find(id);
            if (calculoDepreciacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActivoFijoId = new SelectList(db.ActivoFijo, "Id", "Descripción", calculoDepreciacion.ActivoFijoId);
            return View(calculoDepreciacion);
        }

        // POST: CalculoDepreciacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AñoProceso,MesProceso,ActivoFijoId,DepreciaciónAcumulada,CuentaCompra,CuentaDepreciación,MontoDepreciado,FechaProceso")] CalculoDepreciacion calculoDepreciacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calculoDepreciacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActivoFijoId = new SelectList(db.ActivoFijo, "Id", "Descripción", calculoDepreciacion.ActivoFijoId);
            return View(calculoDepreciacion);
        }

        // GET: CalculoDepreciacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalculoDepreciacion calculoDepreciacion = db.CalculoDepreciacion.Find(id);
            if (calculoDepreciacion == null)
            {
                return HttpNotFound();
            }
            return View(calculoDepreciacion);
        }

        // POST: CalculoDepreciacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CalculoDepreciacion calculoDepreciacion = db.CalculoDepreciacion.Find(id);
            db.CalculoDepreciacion.Remove(calculoDepreciacion);
            db.SaveChanges();
            return RedirectToAction("Index");
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
