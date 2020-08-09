using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Futbol.Models;

namespace Futbol.Controllers
{
    public class JugadorsController : Controller
    {
        private FutbolContext db = new FutbolContext();

        // GET: Jugadors
        public ActionResult Index()
        {
            var jugadors = db.Jugadors.Include(j => j.Equipo);
            return View(jugadors.ToList());
        }

        // GET: Jugadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = db.Jugadors.Find(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // GET: Jugadors/Create
        public ActionResult Create()
        {
            ViewBag.equipoID = new SelectList(db.Equipoes, "equipoID", "nombreEquipo");
            return View();
        }

        // POST: Jugadors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "jugadorID,nombreJugador,edadJugador,paisOrigen,equipoID")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                db.Jugadors.Add(jugador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.equipoID = new SelectList(db.Equipoes, "equipoID", "nombreEquipo", jugador.equipoID);
            return View(jugador);
        }

        // GET: Jugadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = db.Jugadors.Find(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            ViewBag.equipoID = new SelectList(db.Equipoes, "equipoID", "nombreEquipo", jugador.equipoID);
            return View(jugador);
        }

        // POST: Jugadors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "jugadorID,nombreJugador,edadJugador,paisOrigen,equipoID")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jugador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.equipoID = new SelectList(db.Equipoes, "equipoID", "nombreEquipo", jugador.equipoID);
            return View(jugador);
        }

        // GET: Jugadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = db.Jugadors.Find(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // POST: Jugadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jugador jugador = db.Jugadors.Find(id);
            db.Jugadors.Remove(jugador);
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
