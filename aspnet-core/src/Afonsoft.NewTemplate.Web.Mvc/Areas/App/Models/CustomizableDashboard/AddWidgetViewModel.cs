using System.Collections.Generic;
using Afonsoft.NewTemplate.DashboardCustomization.Dto;

namespace Afonsoft.NewTemplate.Web.Areas.App.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
