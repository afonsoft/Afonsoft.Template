using System.Threading.Tasks;
using Afonsoft.NewTemplate.ApiClient;
using Afonsoft.NewTemplate.ApiClient.Models;
using Afonsoft.NewTemplate.Sessions.Dto;

namespace Afonsoft.NewTemplate.Services.Storage
{
    public interface IDataStorageService
    {
        Task StoreAccessTokenAsync(string newAccessToken);

        Task StoreAuthenticateResultAsync(AbpAuthenticateResultModel authenticateResultModel);

        AbpAuthenticateResultModel RetrieveAuthenticateResult();

        TenantInformation RetrieveTenantInfo();

        GetCurrentLoginInformationsOutput RetrieveLoginInfo();

        void ClearSessionPersistance();

        Task StoreLoginInformationAsync(GetCurrentLoginInformationsOutput loginInfo);

        Task StoreTenantInfoAsync(TenantInformation tenantInfo);
    }
}
