using Abp.AutoMapper;
using Afonsoft.NewTemplate.Organizations.Dto;

namespace Afonsoft.NewTemplate.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}