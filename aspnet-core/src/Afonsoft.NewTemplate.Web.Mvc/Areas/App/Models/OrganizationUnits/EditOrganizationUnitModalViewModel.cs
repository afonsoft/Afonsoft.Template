using Abp.AutoMapper;
using Abp.Organizations;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.OrganizationUnits
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class EditOrganizationUnitModalViewModel
    {
        public long? Id { get; set; }

        public string DisplayName { get; set; }
    }
}