using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentSystem.Models;

namespace RentSystem.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        RentContext context = ContextHolder.Context;
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Registered()
        {
            ViewBag.Id = Session["userId"].ToString();
            ViewBag.Login = Session["userLogin"].ToString();
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User user)
        {
            // var context = ContextHolder.Context;
            context.Users.Add(user);
            context.SaveChanges();
            Session["userId"] = user.User_Id;
            Session["userLogin"] = user.Login;

            return RedirectToAction("Registered");
        }
    }
}
