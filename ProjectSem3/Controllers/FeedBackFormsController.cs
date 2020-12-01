using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.Models;
using Project.Models.DataMapper;

namespace ProjectSem3.Controllers
{
    public class FeedBackFormsController : Controller
    {
        private DB_SHOP db = new DB_SHOP();

        // GET: FeedBackForms
        public ActionResult Index()
        {
            var feedBackForms = db.FeedBackForms.Include(f => f.Users);
            return View(feedBackForms.ToList());
        }

        // GET: FeedBackForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedBackForm feedBackForm = db.FeedBackForms.Find(id);
            if (feedBackForm == null)
            {
                return HttpNotFound();
            }
            return View(feedBackForm);
        }

        // GET: FeedBackForms/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName");
            return View();
        }

        // POST: FeedBackForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FeedBackId,Content,UserId")] FeedBackForm feedBackForm)
        {
            if (ModelState.IsValid)
            {
                db.FeedBackForms.Add(feedBackForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", feedBackForm.UserId);
            return View(feedBackForm);
        }

        // GET: FeedBackForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedBackForm feedBackForm = db.FeedBackForms.Find(id);
            if (feedBackForm == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", feedBackForm.UserId);
            return View(feedBackForm);
        }

        // POST: FeedBackForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FeedBackId,Content,UserId")] FeedBackForm feedBackForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feedBackForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "UserId", "UserName", feedBackForm.UserId);
            return View(feedBackForm);
        }

        // GET: FeedBackForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedBackForm feedBackForm = db.FeedBackForms.Find(id);
            if (feedBackForm == null)
            {
                return HttpNotFound();
            }
            return View(feedBackForm);
        }

        // POST: FeedBackForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FeedBackForm feedBackForm = db.FeedBackForms.Find(id);
            db.FeedBackForms.Remove(feedBackForm);
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
