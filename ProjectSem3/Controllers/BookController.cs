using Project.BAL.Repositories;
using Project.Models;
using Project.Models.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSem3.Controllers
{
    [RoutePrefix("/Books")]
    public class BookController : Controller
    {
        Repository<Book> _book;
        private DB_SHOP db = new DB_SHOP();

        public BookController()
        {
            _book = new Repository<Book>();
        }

        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        [Route("Search/{name}")]
        [HttpGet]
        public ActionResult searchBookByName(string name)
        {
            ViewBag.name = name;
            return View("Index");
        }
        //Check exit
        private bool BookExists(int id)
        {

            return db.Books.AsQueryable().Count(x => x.BookId == id) > 0;
        }

        //Detail
        public ActionResult ProductDetails(int id)
        {
            if (BookExists(id))
            {

            }
            return View();
        }
        [Route("Details/{id:int}")]
        [HttpGet]
        public ActionResult Details(int id)
        {
            if (BookExists(id))
            {

                ViewBag.id = id;
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}