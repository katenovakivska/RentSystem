using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentSystem.Models;

namespace RentSystem.Controllers
{
    public class EnterController : Controller
    {
        RentContext context = ContextHolder.Context;
        // GET: Enter
        [HttpGet]
        public ActionResult Entering()
        {
            return View();
        }

        //[HttpGet]
        public ActionResult Entered()
        {
            ViewBag.Id = Session["userId"].ToString();
            ViewBag.Login = Session["userLogin"].ToString();
            return View();
        }

        //[HttpPost]
        //public ActionResult Entered()
        //{
        //    ViewBag.Id = Session["userId"].ToString();
        //    ViewBag.Login = Session["userLogin"].ToString();
        //    return View();
        //}

        [HttpPost]
        public ActionResult Entering(string Login, string Password)
        {
            var users = context.Users.ToList().Find(
                delegate (User user)
                {
                    return user.Password == Password && user.Login == Login;
                });
            if (users != null)
            {
                Session["userId"] = users.User_Id;
                Session["userLogin"] = users.Login;
                return RedirectToAction("Entered");
            }
            else
                return RedirectToAction("Entering");
        }
    }
}