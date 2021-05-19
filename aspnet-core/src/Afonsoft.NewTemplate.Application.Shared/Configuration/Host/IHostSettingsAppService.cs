using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.NewTemplate.Configuration.Host.Dto;

namespace Afonsoft.NewTemplate.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
