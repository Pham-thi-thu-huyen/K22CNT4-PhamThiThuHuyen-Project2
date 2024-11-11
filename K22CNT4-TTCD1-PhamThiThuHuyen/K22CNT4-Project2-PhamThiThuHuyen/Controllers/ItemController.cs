using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K22CNT4_Project2_PhamThiThuHuyen.Models;
using K22CNT4_TTCD1_PhamThiThuHuyen.Models;

namespace K22CNT4_Project2_PhamThiThuHuyen.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        private Entities db = new Entities();
        public ItemController()
        {
            _context = new ApplicationDbContext(); // Khởi tạo _context
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose(); // Giải phóng tài nguyên
            }
            base.Dispose(disposing);
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            // Fetch the item based on the provided ID
            var item = db.tb_Product.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return HttpNotFound(); // Return a 404 if item is not found
            }

            return View(item); // Pass the item to the Details view
        }
    }
}
