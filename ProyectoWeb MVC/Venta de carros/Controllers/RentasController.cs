﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Venta_de_carros.Models;

namespace Venta_de_carros.Controllers
{
    public class RentasController : Controller
    {
        private CarrosWebEntities db = new CarrosWebEntities();

        // GET: Rentas
        public ActionResult Index()
        {
            var rentas = db.Rentas.Include(r => r.Carro).Include(r => r.Cliente);
            return View(rentas.ToList());
        }

        // GET: Rentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renta renta = db.Rentas.Find(id);
            if (renta == null)
            {
                return HttpNotFound();
            }
            return View(renta);
        }

        // GET: Rentas/Create
        public ActionResult Create()
        {
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Nombre");
            ViewBag.IdCliente = new SelectList(db.Clientes, "IdCliente", "Nombre");
            return View();
        }

        // POST: Rentas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdRenta,IdCarro,IdCliente,Duracion,Fecha")] Renta renta)
        {
            if (ModelState.IsValid)
            {
                db.Rentas.Add(renta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Nombre", renta.IdCarro);
            ViewBag.IdCliente = new SelectList(db.Clientes, "IdCliente", "Nombre", renta.IdCliente);
            return View(renta);
        }

        // GET: Rentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renta renta = db.Rentas.Find(id);
            if (renta == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Nombre", renta.IdCarro);
            ViewBag.IdCliente = new SelectList(db.Clientes, "IdCliente", "Nombre", renta.IdCliente);
            return View(renta);
        }

        // POST: Rentas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRenta,IdCarro,IdCliente,Duracion,Fecha")] Renta renta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(renta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Nombre", renta.IdCarro);
            ViewBag.IdCliente = new SelectList(db.Clientes, "IdCliente", "Nombre", renta.IdCliente);
            return View(renta);
        }

        // GET: Rentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Renta renta = db.Rentas.Find(id);
            if (renta == null)
            {
                return HttpNotFound();
            }
            return View(renta);
        }

        // POST: Rentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Renta renta = db.Rentas.Find(id);
            db.Rentas.Remove(renta);
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
