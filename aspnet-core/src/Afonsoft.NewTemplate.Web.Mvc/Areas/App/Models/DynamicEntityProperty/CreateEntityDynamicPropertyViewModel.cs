using System.Collections.Generic;
using Afonsoft.NewTemplate.DynamicEntityProperties.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
