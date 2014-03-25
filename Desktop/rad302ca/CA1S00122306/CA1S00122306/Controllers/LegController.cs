using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA1S00122306.Models;
using CA1S00122306.DAL;

namespace CA1S00122306.Controllers
{
    public class LegController : Controller
    {
        private TravelContext db = new TravelContext();

        //
        // GET: /Leg/

        public ActionResult Index()
        {
            return View(db.Legs.ToList());
        }

        //
        // GET: /Leg/Details/5

        public ActionResult Details(int id = 0)
        {
            Leg leg = db.Legs.Find(id);
            if (leg == null)
            {
                return HttpNotFound();
            }
            return View(leg);
        }

        //
        // GET: /Leg/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Leg/Create

        [HttpPost]
        public ActionResult Create(Leg leg)
        {
            if (ModelState.IsValid)
            {
                db.Legs.Add(leg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leg);
        }

        //
        // GET: /Leg/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Leg leg = db.Legs.Find(id);
            if (leg == null)
            {
                return HttpNotFound();
            }
            return View(leg);
        }

        //
        // POST: /Leg/Edit/5

        [HttpPost]
        public ActionResult Edit(Leg leg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leg);
        }

        //
        // GET: /Leg/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Leg leg = db.Legs.Find(id);
            if (leg == null)
            {
                return HttpNotFound();
            }
            return View(leg);
        }

        //
        // POST: /Leg/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Leg leg = db.Legs.Find(id);
            db.Legs.Remove(leg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}