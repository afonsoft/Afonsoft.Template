﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.NewTemplate.Web.Areas.App.Models.Layout;
using Afonsoft.NewTemplate.Web.Session;
using Afonsoft.NewTemplate.Web.Views;

namespace Afonsoft.NewTemplate.Web.Areas.App.Views.Shared.Themes.Theme10.Components.AppTheme10Footer
{
    public class AppTheme10FooterViewComponent : NewTemplateViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme10FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
