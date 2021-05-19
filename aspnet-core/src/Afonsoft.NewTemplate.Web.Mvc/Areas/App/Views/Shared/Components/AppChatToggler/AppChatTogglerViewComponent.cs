using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.NewTemplate.Web.Areas.App.Models.Layout;
using Afonsoft.NewTemplate.Web.Views;

namespace Afonsoft.NewTemplate.Web.Areas.App.Views.Shared.Components.AppChatToggler
{
    public class AppChatTogglerViewComponent : NewTemplateViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass
            }));
        }
    }
}
