using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using FantasyBurgers.Models;
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
    File Description: Allows the user to check out, after selecting their food items for their cart. -->*/
namespace FantasyBurgers.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        FantasyBurgerContext storeDB = new FantasyBurgerContext();
        private const string PromoCode = "FREE";

        //
        // GET: /Checkout/AddressAndPayment
        public ActionResult AddressAndPayment()
        {
            return View();
        }

        //
        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);

            try
            {
                if (string.Equals(values["PromoCode"], PromoCode,
                    StringComparison.OrdinalIgnoreCase) == false)
                {
                    return View(order);
                }
                else
                {
                    order.Username = User.Identity.Name;
                    order.OrderDate = DateTime.Now;

                    //Save Order
                    storeDB.Orders.Add(order);
                    storeDB.SaveChanges();
                    //Process the order
                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);

                    return RedirectToAction("Complete",
                        new { id = order.OrderId });
                }
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        //
        // GET: /Checkout/Complete
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = storeDB.Orders.Any(
                o => o.OrderId == id &&
                o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}