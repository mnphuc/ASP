using Project.BAL.Repositories;
using Project.Models.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSem3.Controllers
{
    public class UsersController : Controller
    {
        Repository<Users> _u;

        // GET: User
        public UsersController()
        {
            _u = new Repository<Users>();
        }
        public ActionResult Index()
        {
            return View(_u.GetAll());
        }
        public ActionResult Login(UserLogin c)
        {
            if (ModelState.IsValid)
            {
                var cus = _u.SingleBy(x => x.UserName == c.UserName.ToLower() && x.PassWord == c.Password);

                if (cus != null) // Tìm thấy
                {
                    Session["cus"] = cus;
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Sai tài khoản hoặc mật khẩu");
                return View();

            }
            return View();
        }

        public ActionResult Details(int id)
        {
            return View(_u.Get(id));
        }
        public ActionResult Create()
        {
            if (Session["cus"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Create(UserRegisterModel u)
        {
            if (ModelState.IsValid)
            {
                Users us = new Users();
                us.UserName = u.UserName;
                us.PassWord = u.Password;
                us.Email = u.Email;
                us.Address = u.Address;
                us.PassWord = u.Password;
                us.FullName = u.FullName;
                us.Status = true;
                us.GroupId = 3;

                _u.Add(us);
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            return View(_u.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Users u)
        {
            _u.Edit(u);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _u.Remove(id);

            return RedirectToAction("Index");
        }
    }
}