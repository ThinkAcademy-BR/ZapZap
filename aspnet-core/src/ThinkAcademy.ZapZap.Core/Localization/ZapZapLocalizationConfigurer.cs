using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ThinkAcademy.ZapZap.Localization
{
    public static class ZapZapLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ZapZapConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ZapZapLocalizationConfigurer).GetAssembly(),
                        "ThinkAcademy.ZapZap.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
