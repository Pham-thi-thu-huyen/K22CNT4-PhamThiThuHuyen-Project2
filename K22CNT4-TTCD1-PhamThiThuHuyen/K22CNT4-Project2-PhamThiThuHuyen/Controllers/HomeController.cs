using K22CNT4_TTCD1_PhamThiThuHuyen.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace K22CNT4_TTCD1_PhamThiThuHuyen.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();
        public List<tb_Product> Product { get; set; }
        public ActionResult Index()
        {
            // Fetch all products from the database
            var products = db.tb_Product.ToList(); 

            // Pass the list of products to the view
            return View(products);
        }


        private class Admin
        {
            public string Tk { get; set; } = "Admin";
            public string Password { get; set; } = "admin";
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User User)
        {
            if (ModelState.IsValid)
            {
           
                db.Users.Add(User);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(User);
        }
        public ActionResult Login()
        {
            return View(new User()); // Return a new User model
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User model) // Accept the User model
        {
            if (ModelState.IsValid)
            {
                // Validate user credentials
                var user = db.Users.FirstOrDefault(u => u.userName == model.userName);

                if (user != null && user.password == model.password) // Use hashed comparison in production
                {
                    Session["userName"] = user.userName;
                    Session["idUser"] = user.userID;
                    return RedirectToAction("Index");
                }
                var adminUser = new Admin();
                if (model.userName == adminUser.Tk && model.password == adminUser.Password)
                {
                    Session["FullName"] = "Admin";
                    return RedirectToAction("Home", "Admin");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }

            ViewBag.Error = "Login failed. Please check your credentials.";
            return View(model); // Return the model to preserve user input
        }
    }
}
