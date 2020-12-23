using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyLending.Domain;
using MyLending.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            ViewBag.ContentSkills = dataManager.Skills.GetSkills();
            ViewBag.MetaTags = dataManager.Meta.GetMeta();
            ViewBag.AboutMe = dataManager.Information.GetInformationByCodeWord("PageAboutMe");
            ViewBag.Skills = dataManager.Information.GetInformationByCodeWord("PageSkills");
            ViewBag.Experience = dataManager.Information.GetInformationByCodeWord("PageExperience");
            ViewBag.Education = dataManager.Information.GetInformationByCodeWord("PageEducation");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
