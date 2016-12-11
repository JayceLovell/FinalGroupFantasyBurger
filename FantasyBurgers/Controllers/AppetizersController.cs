using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FantasyBurgers.Models;
/*<!--Author's name: Waynell Lovell,
                   Thiago De Andrade Souza,
                   Edward Song,
                   Sahil Mahajan,
                   Anmol .
    Date Created: November 30th, 2016
    Version	History: Part-1.Project Concept, Landing Page &	Site Security,
                     Part-2.Main Functionality & Database Connectivity,
                     Part-3.Finished Version – Fully Styled	and	Functional
    File Description: Allows the user to acces the appetizer model. -->*/
namespace FantasyBurgers.Controllers
{
    public class AppetizersController : Controller
    {
        private FantasyBurgerContext db = new FantasyBurgerContext();

        // GET: Appetizers
        public ActionResult Index()
        {
            return View(db.Appetizers.ToList());
        }

        [Authorize(Roles ="Admin")]
        //Get: Appetziers/Admin
        public ActionResult Admin()
        {
            return View(db.Appetizers.ToList());
        }

        // GET: Appetizers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appetizer appetizer = db.Appetizers.Find(id);
            if (appetizer == null)
            {
                return HttpNotFound();
            }
            return View(appetizer);
        }

        [Authorize(Roles = "Admin")]
        // GET: Appetizers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appetizers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AppetizerId,AppetizerName,AppetizerShortDescription,AppetizerLongDescription,AppetizerPrice,AppetizerImage")] Appetizer appetizer)
        {
            if (ModelState.IsValid)
            {
                db.Appetizers.Add(appetizer);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(appetizer);
        }

        [Authorize(Roles = "Admin")]
        // GET: Appetizers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appetizer appetizer = db.Appetizers.Find(id);
            if (appetizer == null)
            {
                return HttpNotFound();
            }
            return View(appetizer);
        }

        // POST: Appetizers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AppetizerId,AppetizerName,AppetizerShortDescription,AppetizerLongDescription,AppetizerPrice,AppetizerImage")] Appetizer appetizer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appetizer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin");
            }
            return View(appetizer);
        }

        [Authorize(Roles = "Admin")]
        // GET: Appetizers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appetizer appetizer = db.Appetizers.Find(id);
            if (appetizer == null)
            {
                return HttpNotFound();
            }
            return View(appetizer);
        }

        // POST: Appetizers/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appetizer appetizer = db.Appetizers.Find(id);
            db.Appetizers.Remove(appetizer);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }

        [Authorize(Roles = "Admin")]
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
