using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FantasyBurgers.Models;
using FantasyBurgers.ViewModels;
using System.Diagnostics;

namespace FantasyBurgers.Controllers {
    public class ShoppingCartController : Controller {
        FantasyBurgerContext storeDB = new FantasyBurgerContext();

        // GET: /ShoppingCart/

        public ActionResult Index() {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            // Return the view
            return View(viewModel);
        }

        // GET: /ShoppingCart/AddToCart/5
        public ActionResult AddToCart(string itemType, int itemId) {

            // Retrieve the Appetizer from the database
            var purchasableItem = storeDB.getItem(itemType, itemId);

            if (purchasableItem == null) {
                Debug.WriteLine("Could not find purchasable item: " + itemType + " / " + itemId);
                return RedirectToAction("Index");
            }

            // Add it to the shopping cart
            var cart = ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(purchasableItem);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        // AJAX: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id) {
            // Remove the item from the cart
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Get the name of the item to display confirmation
            string itemName = storeDB.Carts.Single(item => item.RecordId == id).getItem().getName();

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new ShoppingCartRemoveViewModel {
                Message = Server.HtmlEncode(itemName) + " has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };

            return Json(results);
        }

        // GET: /ShoppingCart/CartSummary
        [ChildActionOnly]
        public ActionResult CartSummary() {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();

            return PartialView("CartSummary");
        }
    }
}