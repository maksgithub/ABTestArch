using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Guard.Infrastructure;
using Guard.VisualStates;
using Guard.VisualStates.FullVersion;
using Guard.VisualStates.Main;
using Guard.VisualStates.TrialVersion.Factories;
using Guard.WPF.VisualStates;
using Prism.Mvvm;
using Unity;
using Unity.Injection;

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
            unityContainer.RegisterSingleton<IAppLayoutManager, AppLayoutManager>();
            unityContainer.RegisterSingleton<MainViewModel>();
            unityContainer.RegisterSingleton<TrialVersionFactory>();
            unityContainer.RegisterSingleton<FullVersionFactory>();

            ViewModelLocationProvider.Register<MainView>(() => unityContainer.Resolve<MainViewModel>());
        }
    }
}
