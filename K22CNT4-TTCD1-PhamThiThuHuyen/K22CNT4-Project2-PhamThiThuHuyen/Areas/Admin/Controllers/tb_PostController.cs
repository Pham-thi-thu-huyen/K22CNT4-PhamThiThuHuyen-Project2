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
    public class tb_PostController : Controller
    {
        private Entities db = new Entities();

        // GET: Admin/tb_Post
        public ActionResult Index()
        {
            return View(db.tb_Post.ToList());
        }

        // GET: Admin/tb_Post/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Post tb_Post = db.tb_Post.Find(id);
            if (tb_Post == null)
            {
                return HttpNotFound();
            }
            return View(tb_Post);
        }

        // GET: Admin/tb_Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/tb_Post/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,CategoryId,Description,Detail,Image,SeoTitle,SeoDescription,SeoKeyword,CreateDate,CreateBy,ModifiedDate,ModiferBy")] tb_Post tb_Post)
        {
            if (ModelState.IsValid)
            {
                db.tb_Post.Add(tb_Post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Post);
        }

        // GET: Admin/tb_Post/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Post tb_Post = db.tb_Post.Find(id);
            if (tb_Post == null)
            {
                return HttpNotFound();
            }
            return View(tb_Post);
        }

        // POST: Admin/tb_Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,CategoryId,Description,Detail,Image,SeoTitle,SeoDescription,SeoKeyword,CreateDate,CreateBy,ModifiedDate,ModiferBy")] tb_Post tb_Post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Post);
        }

        // GET: Admin/tb_Post/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Post tb_Post = db.tb_Post.Find(id);
            if (tb_Post == null)
            {
                return HttpNotFound();
            }
            return View(tb_Post);
        }

        // POST: Admin/tb_Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Post tb_Post = db.tb_Post.Find(id);
            db.tb_Post.Remove(tb_Post);
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
