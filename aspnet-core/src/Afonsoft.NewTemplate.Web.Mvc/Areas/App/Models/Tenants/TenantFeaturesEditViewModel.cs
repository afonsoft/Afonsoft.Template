using Abp.AutoMapper;
using Afonsoft.NewTemplate.MultiTenancy;
using Afonsoft.NewTemplate.MultiTenancy.Dto;
using Afonsoft.NewTemplate.Web.Areas.App.Models.Common;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}