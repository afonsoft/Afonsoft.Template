using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Authorization.Permissions.Dto;

namespace Afonsoft.NewTemplate.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
