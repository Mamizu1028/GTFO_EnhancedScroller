using TheArchive.Core;
using TheArchive.Core.Attributes;
using TheArchive.Core.Localization;
using TheArchive.Interfaces;
using TheArchive.Loader;

namespace Hikaria.ES;

[ArchiveModule(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
internal class EntryPoint : IArchiveModule
{
    public ILocalizationService LocalizationService { get; set; }
    public IArchiveLogger Logger { get; set; }

    public void Init()
    {
        LoaderWrapper.ClassInjector.RegisterTypeInIl2Cpp<EnhancedScroller>();
        LoaderWrapper.ClassInjector.RegisterTypeInIl2Cpp<EnhancedScrollerCellView>();
    }
}
