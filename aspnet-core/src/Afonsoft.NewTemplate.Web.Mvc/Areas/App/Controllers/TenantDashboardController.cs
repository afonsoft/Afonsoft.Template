using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.NewTemplate.Authorization;
using Afonsoft.NewTemplate.DashboardCustomization;
using System.Threading.Tasks;
using Afonsoft.NewTemplate.Web.Areas.App.Startup;

namespace Afonsoft.NewTemplate.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(NewTemplateDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}