using Exam2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Exam2.Controllers
{
    public class HomeController : Controller
    {
        private static List<Survey> _surveys = new List<Survey>();

        public IActionResult Index()
        {
            return View("CustomerSurvey");
        }

        public IActionResult CustomerSurvey()
        {
            return View("SurveyResponse", new Survey());
        }

        public IActionResult SurveyResponse(Survey survey)
        {
            _surveys.Add(survey);
            return View(survey);
        }

        public IActionResult SurveySummary()
        {
            return View(_surveys);
        }
    }
}
