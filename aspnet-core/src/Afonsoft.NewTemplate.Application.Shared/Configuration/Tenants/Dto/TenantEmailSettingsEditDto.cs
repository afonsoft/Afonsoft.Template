using Abp.Auditing;
using Afonsoft.NewTemplate.Configuration.Dto;

namespace Afonsoft.NewTemplate.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}