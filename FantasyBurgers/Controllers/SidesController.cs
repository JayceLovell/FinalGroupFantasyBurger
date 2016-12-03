using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FantasyBurgers.Models;

namespace FantasyBurgers.Controllers
{
    public class SidesController : Controller
    {
        private FantasyBurgersFinalContext db = new FantasyBurgersFinalContext();

        // GET: Sides
        public ActionResult Index()
        {
            return View(db.Sides.ToList());
        }

        // GET: Sides/Admin
        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View(db.Sides.ToList());
        }

        // GET: Sides/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sides side = db.Sides.Find(id);
            if (side == null)
            {
                return HttpNotFound();
            }
            return View(side);
        }

        // GET: Sides/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sides/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SideId,SideName,SideShortDescription,SideLongDescription,SidePrice,SideImage")] Sides side)
        {
            if (ModelState.IsValid)
            {
                db.Sides.Add(side);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(side);
        }

        // GET: Sides/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sides side = db.Sides.Find(id);
            if (side == null)
            {
                return HttpNotFound();
            }
            return View(side);
        }

        // POST: Sides/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SideId,SideName,SideShortDescription,SideLongDescription,SidePrice,SideImage")] Sides side)
        {
            if (ModelState.IsValid)
            {
                db.Entry(side).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(side);
        }

        // GET: Sides/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sides side = db.Sides.Find(id);
            if (side == null)
            {
                return HttpNotFound();
            }
            return View(side);
        }

        // POST: Sides/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sides side = db.Sides.Find(id);
            db.Sides.Remove(side);
            db.SaveChanges();
            return RedirectToAction("Admin");
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
