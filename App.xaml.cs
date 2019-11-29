using Prism.Ioc;
using TicTok.Views;
using System.Windows;
using Prism.Modularity;
using TicToke.Module.Page;

namespace TicTok
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<PageModule>();
        }
    }
}
