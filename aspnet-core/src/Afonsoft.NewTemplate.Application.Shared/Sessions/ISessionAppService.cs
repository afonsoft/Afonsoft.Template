using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.NewTemplate.Sessions.Dto;

namespace Afonsoft.NewTemplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
