using Microsoft.AspNetCore.Mvc;
using MyLending.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLending.Models.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;
        public FooterViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Footer"));
        }
    }
}
