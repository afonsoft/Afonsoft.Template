using System.Collections.Generic;
using Abp.Localization;
using Afonsoft.NewTemplate.Install.Dto;

namespace Afonsoft.NewTemplate.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
