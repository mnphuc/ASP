using Project.BAL.Repositories;
using Project.Models.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSem3.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        Repository<Users> _user;
        public HomeController()
        {
            _user = new Repository<Users>();
        }
        // GET: Admin/Home
        public ActionResult Index()
        {
            Users users1 = new Users();
            users1.UserName = "abc";
            if (_user.Add(users1))
            {

            }
            var users = _user.GetAll();
            ViewBag.users = users;
            return View(_user.GetAll());
        }
    }
}