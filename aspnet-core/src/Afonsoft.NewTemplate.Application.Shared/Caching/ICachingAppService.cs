using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Caching.Dto;

namespace Afonsoft.NewTemplate.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
