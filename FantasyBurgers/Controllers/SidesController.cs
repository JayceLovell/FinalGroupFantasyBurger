﻿using System;
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
    File Description: Allows the user to access the side view. -->*/
namespace FantasyBurgers.Controllers
{
    public class SidesController : Controller
    {
        private FantasyBurgerContext db = new FantasyBurgerContext();

        // GET: Sides
        public ActionResult Index()
        {
            return View(db.Sides.ToList());
        }

        //Get: Sides/Admin
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
            Side side = db.Sides.Find(id);
            if (side == null)
            {
                return HttpNotFound();
            }
            return View(side);
        }

        // GET: Sides/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sides/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "SideId,SideName,SideShortDescription,SideLongDescription,SidePrice,SideImage")] Side side)
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
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Side side = db.Sides.Find(id);
            if (side == null)
            {
                return HttpNotFound();
            }
            return View(side);
        }

        // POST: Sides/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SideId,SideName,SideShortDescription,SideLongDescription,SidePrice,SideImage")] Side side)
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
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Side side = db.Sides.Find(id);
            if (side == null)
            {
                return HttpNotFound();
            }
            return View(side);
        }

        // POST: Sides/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Side side = db.Sides.Find(id);
            db.Sides.Remove(side);
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
