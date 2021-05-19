using Abp.AutoMapper;
using Afonsoft.NewTemplate.Sessions.Dto;

namespace Afonsoft.NewTemplate.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}