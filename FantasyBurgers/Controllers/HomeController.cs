using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*<!--Author's name: Waynell Lovell,
                   Thiago De Andrade Souza,
                   Edward Song,
                   Sahil Mahajan,
                   Anmol .
    Date Created: November 30th, 2016
    Version	History: Part-1.Project Concept, Landing Page &	Site Security,
                     Part-2.Main Functionality & Database Connectivity,
                     Part-3.Finished Version – Fully Styled	and	Functional
    File Description: Allows the user to access the home view. -->*/
namespace FantasyBurgers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}