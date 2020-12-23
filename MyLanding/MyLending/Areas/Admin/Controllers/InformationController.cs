using Microsoft.AspNetCore.Mvc;
using MyLending.Domain;
using MyLending.Domain.Entities;
using MyLending.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InformationController : Controller
    {
        private readonly DataManager dataManager;
        public InformationController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(string codeWord)
        {
            ViewBag.Code = codeWord;
            var entity = dataManager.Information.GetInformationByCodeWord(codeWord);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Information model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Information.SaveInformation(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
