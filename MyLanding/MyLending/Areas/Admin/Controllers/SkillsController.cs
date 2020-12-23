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
    public class SkillsController : Controller
    {
        private readonly DataManager dataManager;
        public SkillsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.Skills.GetSkills());
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Skills() : dataManager.Skills.GetSkillsById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Skills model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Skills.SaveSkills(model);
                return RedirectToAction(nameof(SkillsController.Index), nameof(SkillsController).CutController()); ;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Skills.DeleteSkills(id);
            return RedirectToAction(nameof(SkillsController.Index), nameof(SkillsController).CutController());
        }
    }
}
