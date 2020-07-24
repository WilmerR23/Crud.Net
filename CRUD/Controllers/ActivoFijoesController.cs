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
    public class ActivoFijoesController : Controller
    {
        private Context db = new Context();

        // GET: ActivoFijoes
        public ActionResult Index()
        {
            var activoFijo = db.ActivoFijo.Include(a => a.Departamento).Include(a => a.TipoActivo);
            foreach (var item in activoFijo)
            {
                item.CalculoDepreciacion = db.CalculoDepreciacion.FirstOrDefault(x => x.ActivoFijoId == item.Id)?.MontoDepreciado ?? 0;
            }
            return View(activoFijo.ToList());
        }

        // GET: ActivoFijoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivoFijo activoFijo = db.ActivoFijo.Find(id);
            activoFijo.CalculoDepreciacion = db.CalculoDepreciacion.FirstOrDefault(x => x.ActivoFijoId == activoFijo.Id)?.MontoDepreciado ?? 0;
            
            if (activoFijo == null)
            {
                return HttpNotFound();
            }
            return View(activoFijo);
        }

        // GET: ActivoFijoes/Create
        public ActionResult Create()
        {
            ViewBag.DepartamentoId = new SelectList(db.Departamento, "Id", "Descripcion");
            ViewBag.TipoActivoId = new SelectList(db.TipoActivo, "Id", "Descripcion");
            return View();
        }

        // POST: ActivoFijoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descripción,DepartamentoId,TipoActivoId,FechaRegistro,ValorCompra,CalculoDepreciacion")] ActivoFijo activoFijo)
        {
            if (ModelState.IsValid)
            {
                db.ActivoFijo.Add(activoFijo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartamentoId = new SelectList(db.Departamento, "Id", "Descripcion", activoFijo.DepartamentoId);
            ViewBag.TipoActivoId = new SelectList(db.TipoActivo, "Id", "Descripcion", activoFijo.TipoActivoId);
            return View(activoFijo);
        }

        // GET: ActivoFijoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivoFijo activoFijo = db.ActivoFijo.Find(id);
            activoFijo.CalculoDepreciacion = db.CalculoDepreciacion.FirstOrDefault(x => x.ActivoFijoId == activoFijo.Id)?.MontoDepreciado ?? 0;
            if (activoFijo == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamento, "Id", "Descripcion", activoFijo.DepartamentoId);
            ViewBag.TipoActivoId = new SelectList(db.TipoActivo, "Id", "Descripcion", activoFijo.TipoActivoId);
            return View(activoFijo);
        }

        // POST: ActivoFijoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descripción,DepartamentoId,TipoActivoId,FechaRegistro,ValorCompra,CalculoDepreciacion")] ActivoFijo activoFijo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activoFijo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamento, "Id", "Descripcion", activoFijo.DepartamentoId);
            ViewBag.TipoActivoId = new SelectList(db.TipoActivo, "Id", "Descripcion", activoFijo.TipoActivoId);
            return View(activoFijo);
        }

        // GET: ActivoFijoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActivoFijo activoFijo = db.ActivoFijo.Find(id);
            if (activoFijo == null)
            {
                return HttpNotFound();
            }
            return View(activoFijo);
        }

        // POST: ActivoFijoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActivoFijo activoFijo = db.ActivoFijo.Find(id);
            db.ActivoFijo.Remove(activoFijo);
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
