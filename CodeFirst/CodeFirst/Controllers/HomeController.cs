using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            using (var ctx = new Roster())
            {
                var swimmer = new Swimmer()
                {
                    FirstName = "Connor",
                    LastName = "Sharpe",
                    stroke = "Free",
                    distance = "Sprint"
                };
                ctx.Swimmers.Add(swimmer);
                ctx.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}