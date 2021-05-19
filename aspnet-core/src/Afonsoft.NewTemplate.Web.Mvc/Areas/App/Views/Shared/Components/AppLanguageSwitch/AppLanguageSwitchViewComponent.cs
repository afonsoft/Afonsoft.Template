using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.NewTemplate.Web.Areas.App.Models.Layout;
using Afonsoft.NewTemplate.Web.Views;

namespace Afonsoft.NewTemplate.Web.Areas.App.Views.Shared.Components.AppLanguageSwitch
{
    public class AppLanguageSwitchViewComponent : NewTemplateViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AppLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
