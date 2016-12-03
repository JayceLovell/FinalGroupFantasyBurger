using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FantasyBurgers.Models;
using FantasyBurgers.ViewModels;

namespace FantasyBurgers.Controllers
{
    public class CartsController : Controller
    {
        private FantasyBurgersFinalContext db = new FantasyBurgersFinalContext();

        // GET: Carts
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new CartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };
            // Return the view
            return View(viewModel);
        }

        // Get: /Store/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            // Retrieve the item from the database
            var addeditem = db.Appetizers.Single(Appetizer => Appetizer.AppetizerId == id);

            // Add it to the shopping cart
            var cart = ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(addeditem);

            // Go back to the main page for more shopping
            return RedirectToAction("Index");
        }

        // AJAX: /Car/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from teh cart
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Get the name of the item to display confirmation
            string itemName = db.Carts.Single(item => item.RecordId == id).Appetizer.AppetizerName;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // DIsplay the confirmation message
            var results = new CartRemoveViewModel
            {
                Message = Server.HtmlEncode(itemName) + " has been remove from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }

        // Get: /Cart/CarSummary
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            return PartialView("CartSummary");
        }
    }
}
