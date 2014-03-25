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
    public class GuestController : Controller
    {
        private TravelContext db = new TravelContext();

        //
        // GET: /Guest/

        public ActionResult Index()
        {
            return View(db.Guests.ToList());
        }

        //
        // GET: /Guest/Details/5

        public ActionResult Details(int id = 0)
        {
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        //
        // GET: /Guest/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Guest/Create

        [HttpPost]
        public ActionResult Create(Guest guest)
        {
            if (ModelState.IsValid)
            {
                db.Guests.Add(guest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guest);
        }

        //
        // GET: /Guest/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        //
        // POST: /Guest/Edit/5

        [HttpPost]
        public ActionResult Edit(Guest guest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guest);
        }

        //
        // GET: /Guest/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Guest guest = db.Guests.Find(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        //
        // POST: /Guest/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Guest guest = db.Guests.Find(id);
            db.Guests.Remove(guest);
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