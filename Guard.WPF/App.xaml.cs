using System.Windows;
using LoginFullVersion.SplitTest.Extensions;
using Prism.Mvvm;
using SplitTest.Common.Base.ViewModels;
using Unity;

namespace Guard.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var unityContainer = new UnityContainer();
            unityContainer.RegisterSingleton<MainViewModel>();
            unityContainer.RegisterLoginFullVersionSplitTest();

            ViewModelLocationProvider.Register<MainWindow>(() => unityContainer.Resolve<MainViewModel>());
        }
    }
}
