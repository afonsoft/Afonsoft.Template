using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.Authorization.Users.Dto;

namespace Afonsoft.NewTemplate.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
