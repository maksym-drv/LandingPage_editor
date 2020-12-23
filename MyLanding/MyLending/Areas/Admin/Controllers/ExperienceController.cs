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
    public class ExperienceController : Controller
    {
        private readonly DataManager dataManager;
        public ExperienceController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.Experience.GetExperience());
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Experience() : dataManager.Experience.GetExperienceById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Experience model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Experience.SaveExperience(model);
                return RedirectToAction(nameof(ExperienceController.Index), nameof(ExperienceController).CutController()); ;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Experience.DeleteExperience(id);
            return RedirectToAction(nameof(ExperienceController.Index), nameof(ExperienceController).CutController());
        }
    }
}
