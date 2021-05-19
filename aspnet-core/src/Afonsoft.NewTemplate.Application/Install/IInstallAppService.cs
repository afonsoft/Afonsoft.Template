using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.NewTemplate.Install.Dto;

namespace Afonsoft.NewTemplate.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}