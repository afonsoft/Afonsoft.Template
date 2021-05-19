using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.NewTemplate.Editions.Dto;
using Afonsoft.NewTemplate.MultiTenancy.Dto;

namespace Afonsoft.NewTemplate.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}