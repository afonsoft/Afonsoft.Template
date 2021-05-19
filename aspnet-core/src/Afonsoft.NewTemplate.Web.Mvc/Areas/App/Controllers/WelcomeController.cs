using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.NewTemplate.Web.Controllers;

namespace Afonsoft.NewTemplate.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : NewTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}