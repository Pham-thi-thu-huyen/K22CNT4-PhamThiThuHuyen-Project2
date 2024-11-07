using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K22CNT4_Project2_PhamThiThuHuyen.Models;

namespace K22CNT4_Project2_PhamThiThuHuyen.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            var items = new List<Item>
            {
                new Item { Id = 1, Name = "VerSace", Price = 3500000 },
                new Item { Id = 2, Name = "Dior Sauvage", Price = 2800000 },
                new Item { Id = 3, Name = "Charme Guility", Price = 2590000 },
                new Item { Id = 4, Name = "Chanel No.5", Price = 2500000 },
                new Item { Id = 5, Name = "Gucci Flora", Price = 3800000 },
                new Item { Id = 6, Name = "Cabotine Rose", Price = 1590000 }
            };

            return View(items);
        }
    }
}