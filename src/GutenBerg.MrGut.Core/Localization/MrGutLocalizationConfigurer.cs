using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace GutenBerg.MrGut.Localization
{
    public static class MrGutLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MrGutConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MrGutLocalizationConfigurer).GetAssembly(),
                        "GutenBerg.MrGut.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
