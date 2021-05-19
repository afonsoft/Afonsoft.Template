using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Authorization.Users.Dto;

namespace Afonsoft.NewTemplate.Authorization.Users
{
    public interface IUserLinkAppService : IApplicationService
    {
        Task LinkToUser(LinkToUserInput linkToUserInput);

        Task<PagedResultDto<LinkedUserDto>> GetLinkedUsers(GetLinkedUsersInput input);

        Task<ListResultDto<LinkedUserDto>> GetRecentlyUsedLinkedUsers();

        Task UnlinkUser(UnlinkUserInput input);
    }
}
