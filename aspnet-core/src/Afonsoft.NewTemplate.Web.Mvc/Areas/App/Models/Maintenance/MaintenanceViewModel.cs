using System.Collections.Generic;
using Afonsoft.NewTemplate.Caching.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}