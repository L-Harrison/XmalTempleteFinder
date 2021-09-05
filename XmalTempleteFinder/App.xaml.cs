
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Prism;

using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;

using System.Windows;

using XmalTempleteFinder.Views;

namespace XmalTempleteFinder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindow();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TempleteContent>();
        }
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            var factory = Container.Resolve<IRegionBehaviorFactory>();
            var re = DevExpress.Xpf.Prism.AdapterFactory.Make<RegionAdapterBase<DocumentGroup>>(factory);
            regionAdapterMappings.RegisterMapping(typeof(DocumentGroup), re);
        }
    }
}
