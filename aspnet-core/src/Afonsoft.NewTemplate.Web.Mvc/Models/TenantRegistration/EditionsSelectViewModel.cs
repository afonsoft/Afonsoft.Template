using Abp.AutoMapper;
using Afonsoft.NewTemplate.MultiTenancy.Dto;

namespace Afonsoft.NewTemplate.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
