using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Afonsoft.NewTemplate.Localization
{
    public static class NewTemplateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    NewTemplateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NewTemplateLocalizationConfigurer).GetAssembly(),
                        "Afonsoft.NewTemplate.Localization.NewTemplate"
                    )
                )
            );
        }
    }
}