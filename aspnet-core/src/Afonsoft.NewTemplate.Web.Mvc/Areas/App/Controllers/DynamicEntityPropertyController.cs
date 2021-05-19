using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Afonsoft.NewTemplate.Authorization;
using Afonsoft.NewTemplate.DynamicEntityProperties;
using Afonsoft.NewTemplate.Web.Areas.App.Models.DynamicEntityProperty;
using Afonsoft.NewTemplate.Web.Controllers;

namespace Afonsoft.NewTemplate.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_DynamicEntityProperties)]
    public class DynamicEntityPropertyController : NewTemplateControllerBase
    {
        private readonly IDynamicPropertyAppService _dynamicPropertyAppService;
        private readonly IDynamicEntityPropertyAppService _dynamicEntityPropertyAppService;

        public DynamicEntityPropertyController(
            IDynamicPropertyAppService dynamicPropertyAppService,
            IDynamicEntityPropertyAppService dynamicEntityPropertyAppService
        )
        {
            _dynamicPropertyAppService = dynamicPropertyAppService;
            _dynamicEntityPropertyAppService = dynamicEntityPropertyAppService;
        }

        [HttpGet]
        [Route("/App/DynamicEntityProperty/{entityFullName}")]
        public IActionResult Index(string entityFullName)
        {
            ViewBag.EntityFullName = entityFullName;
            return View();
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_DynamicEntityProperties_Create)]
        public async Task<IActionResult> CreateModal(string entityFullName)
        {
            var model = new CreateEntityDynamicPropertyViewModel()
            {
                EntityFullName = entityFullName
            };

            var allDynamicProperties = (await _dynamicPropertyAppService.GetAll()).Items.ToList();
            var definedPropertyIds = (await _dynamicEntityPropertyAppService.GetAllPropertiesOfAnEntity(new DynamicEntityPropertyGetAllInput() {EntityFullName = entityFullName}))
                .Items.Select(x => x.DynamicPropertyId).ToList();

            model.DynamicProperties = allDynamicProperties.Where(x => !definedPropertyIds.Contains(x.Id)).ToList();

            return PartialView("_CreateModal", model);
        }
    }
}