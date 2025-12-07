using CustSurveyMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CustSurveyMVC.Controllers
{
    public class HomeController : Controller
    {
        TechSupportContext db;

        public HomeController(TechSupportContext context)
        {
            db = context;
        }

        static List<Survey> surveys = new List<Survey>();

        public IActionResult Index(int cid)
        {

            return View("CustomerSurvey", new CustomerSurveyViewModel()
            {
                Customers = db.Customers.ToList()
            });
        }

        public IActionResult SurveyResponse(Survey survey)
        {
            surveys.Add(survey);
            db.SaveChanges();
            return View(survey);
        }

        public IActionResult List(int cid)
        {
            return View("SurveySummary", surveys);
        }

    }
}