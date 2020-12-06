using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentSystem.Models;

namespace RentSystem.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        //public ActionResult Searching()
        //{
        //    return View();
        //}
        private RentContext context = ContextHolder.Context;

        [HttpGet]
        public ActionResult Searching()
        {
            return View();
        }
        //[HttpPost]
        public ActionResult Find(string town)
        {
            var apps = context.Appartments;
            List<Appartment> appartments = apps.ToList();
            ViewBag.Appartments = appartments.Where(p => p.Town == town);

            return View();

        }
        }
}