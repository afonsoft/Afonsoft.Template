using Abp.Application.Services;
using Afonsoft.NewTemplate.Dto;
using Afonsoft.NewTemplate.Logging.Dto;

namespace Afonsoft.NewTemplate.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
