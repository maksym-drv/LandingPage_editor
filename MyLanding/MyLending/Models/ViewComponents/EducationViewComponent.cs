using Microsoft.AspNetCore.Mvc;
using MyLending.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Models.ViewComponents
{
    public class EducationViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;
        public EducationViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public Task<IViewComponentResult> InvokeAsync(string codeWord)
        {
            return Task.FromResult((IViewComponentResult)View("Education", dataManager.Education.GetEducation()));
        }
    }
}
