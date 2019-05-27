using NorthwindTrainningProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindTrainningProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ApplicationDbContext db = ApplicationDbContext.Create();
            var ls = db.Categories.ToList();
            return View(ls);
        }
        public ActionResult Hello()
        {
            return View();
        }
    }
}
