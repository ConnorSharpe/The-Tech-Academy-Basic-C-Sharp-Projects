using QuoteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuoteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool dui, int speedingTickets, bool fullCoverage)
        {
            double quote = 50;
            int age = (DateTime.Now.Year - dateOfBirth.Year);

            if(age < 18)
            {
                quote += 100;
            }
            else if (age < 25 || age > 100)
            {
                quote += 25;
            }
            
            if (carYear < 2000 || carYear > 2015)
            {
                quote += 25;
            }

            if(carMake.ToLower() == "porsche")
            {
                quote += 25;
                if(carModel.ToLower() == "911 carrera")
                {
                    quote += 25;
                }
            }
            
            if(speedingTickets > 0)
            {
                quote += (speedingTickets * 10);
            }

            if (dui)
            {
                quote += (quote * .25);
            }

            if (fullCoverage)
            {
                quote += (quote * .5);
            }
            var calculated = new Quote();
            using (QuoteEntities1 db = new QuoteEntities1())
            {
                
                calculated.FirstName = firstName;
                calculated.LastName = lastName;
                calculated.EmailAddress = emailAddress;
                calculated.DateOfBirth = dateOfBirth;
                calculated.CarYear = carYear;
                calculated.CarMake = carMake;
                calculated.CarModel = carModel;
                calculated.DUI = dui;
                calculated.SpeedingTickets = speedingTickets;
                calculated.FullCoverage = fullCoverage;
                calculated.Cost = (decimal)quote;

                db.Quotes.Add(calculated);
                db.SaveChanges();
            }



            return View(calculated.Cost);
        }

        public ActionResult Admin()
        {
            List<Quote> listQuote = new List<Quote>();
            using(QuoteEntities1 db = new QuoteEntities1())
            {
                listQuote = db.Quotes.ToList();
            }
            return View(listQuote);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}