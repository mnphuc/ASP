using Project.BAL.Repositories;
using Project.Models.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSem3.Areas.Admin.Controllers
{
    public class BooksController : Controller
    {
        Repository<Book> _book;
        public BooksController()
        {
            _book = new Repository<Book>();
        }
        // GET: Admin/Books
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Books/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Books/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
