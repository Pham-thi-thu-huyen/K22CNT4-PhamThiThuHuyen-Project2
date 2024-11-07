using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K22CNT4_Project2_PhamThiThuHuyen.Models;

namespace K22CNT4_Project2_PhamThiThuHuyen.Controllers
{
    public class cartController : Controller
    {
        // GET: cart
        private static readonly ShoppingCart _cart = new ShoppingCart();

        public ActionResult Index()
        {
            var items = _cart.GetItems();
            return View(items);
        }

        public ActionResult AddToCart(int itemId, string itemName, decimal price, int quantity)
        {
            _cart.AddItem(itemId, itemName, price, quantity);
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int itemId)
        {
            _cart.RemoveItem(itemId);
            return RedirectToAction("Index");
        }

        public ActionResult ClearCart()
        {
            _cart.Clear();
            return RedirectToAction("Index");
        }

        public ActionResult Checkout()
        {
            var totalAmount = _cart.GetTotal();
            return View(totalAmount);
        }
    }
}