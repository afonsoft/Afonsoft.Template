using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Common.Dto;
using Afonsoft.NewTemplate.Editions.Dto;

namespace Afonsoft.NewTemplate.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}