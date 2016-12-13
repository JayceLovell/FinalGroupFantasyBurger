using FantasyBurgers.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FantasyBurgers.Controllers
{
    public class MenuController : Controller
    {
        private FantasyBurgersFinalContext db = new FantasyBurgersFinalContext();

       // Get: MenuBrowse?Cetgory
       public ActionResult BrowseByCategory(string category)
        {
            if (category==null)
            {
                category = "Appetizer";
            }

            Category categoryModel = db.Categories.Include("Menus").Single(g => g.Category1 == category);

            return View(categoryModel);
        }

        // Get: Store/Details/
        public ActionResult Details(int? id=1)
        {
            Menu menu = db.Menus.Find(id);

            return View(menu);
        }
    }
}