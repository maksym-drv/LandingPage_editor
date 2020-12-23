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
    public class MetaController : Controller
    {
        private readonly DataManager dataManager;
        public MetaController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit()
        {
            var entity = dataManager.Meta.GetMeta();
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Meta model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Meta.SaveMeta(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
