using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.NewTemplate.Configuration.Tenants.Dto;

namespace Afonsoft.NewTemplate.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
