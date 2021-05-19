using Abp.AspNetCore.Mvc.Authorization;
using Afonsoft.NewTemplate.Authorization;
using Afonsoft.NewTemplate.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace Afonsoft.NewTemplate.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}