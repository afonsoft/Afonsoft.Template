using System.Collections.Generic;
using Afonsoft.NewTemplate.DynamicEntityProperties.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
