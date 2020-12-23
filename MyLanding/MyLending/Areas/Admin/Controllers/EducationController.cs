using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLending.Domain;
using MyLending.Domain.Entities;
using MyLending.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EducationController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnviroment;
        public EducationController(DataManager dataManager, IWebHostEnvironment hostingEnviroment)
        {
            this.dataManager = dataManager;
            this.hostingEnviroment = hostingEnviroment;
        }
        public IActionResult Index()
        {
            return View(dataManager.Education.GetEducation());
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Education() : dataManager.Education.GetEducationById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(Education model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.ImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnviroment.WebRootPath, "img/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.Education.SaveEducation(model);
                return RedirectToAction(nameof(EducationController.Index), nameof(EducationController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Education.DeleteEducation(id);
            return RedirectToAction(nameof(EducationController.Index), nameof(EducationController).CutController());
        }
    }
}
