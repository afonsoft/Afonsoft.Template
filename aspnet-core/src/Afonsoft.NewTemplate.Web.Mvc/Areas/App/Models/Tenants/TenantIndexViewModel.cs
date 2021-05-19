using System.Collections.Generic;
using Afonsoft.NewTemplate.Editions.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}