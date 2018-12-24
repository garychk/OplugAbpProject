using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OplugAbpProject.Localization
{
    public static class OplugAbpProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OplugAbpProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OplugAbpProjectLocalizationConfigurer).GetAssembly(),
                        "OplugAbpProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
