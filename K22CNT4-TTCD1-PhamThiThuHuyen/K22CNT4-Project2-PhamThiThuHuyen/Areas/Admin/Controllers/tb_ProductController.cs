using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using K22CNT4_TTCD1_PhamThiThuHuyen.Models;

namespace K22CNT4_TTCD1_PhamThiThuHuyen.Areas.Admin.Controllers
{
    public class tb_ProductController : Controller
    {
        private Entities db = new Entities();

        // GET: Admin/tb_Product
        public ActionResult Index()
        {
            return View(db.tb_Product.ToList());
        }

        // GET: Admin/tb_Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Product tb_Product = db.tb_Product.Find(id);
            if (tb_Product == null)
            {
                return HttpNotFound();
            }
            return View(tb_Product);
        }

        // GET: Admin/tb_Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/tb_Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,ProductCategoryID,Description,Detail,image,Price,PriceSale,Quantity,SeoTitle,SeoDescription,SeoKeyword,CreateDate,CreateBy,ModifedDate,ModiferBy")] tb_Product tb_Product)
        {
            if (ModelState.IsValid)
            {
                db.tb_Product.Add(tb_Product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Product);
        }

        // GET: Admin/tb_Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Product tb_Product = db.tb_Product.Find(id);
            if (tb_Product == null)
            {
                return HttpNotFound();
            }
            return View(tb_Product);
        }

        // POST: Admin/tb_Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,ProductCategoryID,Description,Detail,image,Price,PriceSale,Quantity,SeoTitle,SeoDescription,SeoKeyword,CreateDate,CreateBy,ModifedDate,ModiferBy")] tb_Product tb_Product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Product);
        }

        // GET: Admin/tb_Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Product tb_Product = db.tb_Product.Find(id);
            if (tb_Product == null)
            {
                return HttpNotFound();
            }
            return View(tb_Product);
        }

        // POST: Admin/tb_Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Product tb_Product = db.tb_Product.Find(id);
            db.tb_Product.Remove(tb_Product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
