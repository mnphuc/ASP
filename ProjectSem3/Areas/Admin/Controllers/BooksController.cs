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
        // show all list book
        public ActionResult Index()
        {
            ViewBag.books = _book.GetAll();
            return View();
        }

        // GET: Admin/Books/Details/5
        // get book where ID
        public ActionResult Details(int id)
        {
            ViewBag.bookDetail = _book.Get(id);
            return View();
        }

        // GET: Admin/Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Books/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                // TODO: Add insert logic here
                bool check = _book.Add(book);
                if (check)
                {
                    return RedirectToAction("Index");
                }
                else return View();
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Books/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.book = _book.Get(id);
            return View();
        }

        // POST: Admin/Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book book)
        {
            try
            {
                // TODO: Add update logic here
                if (_book.Edit(book))
                {
                    return RedirectToAction("Index");
                }
                else return View();
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Books/Delete/5
        // using model submit
        public ActionResult Delete(int id)
        {
            _book.Remove(id);
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
