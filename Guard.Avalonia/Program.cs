using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using System;
using Guard.BL;
using Guard.BL.Factories;
using Guard.BL.Models;
using Guard.Infrastructure;
using Guard.Models;
using Guard.VisualStates.FullVersion;
using Guard.VisualStates.Main;
using Guard.VisualStates.Onboarding;
using Guard.VisualStates.TrialVersion.Factories;
using Prism.Mvvm;
using Unity;

namespace Guard.Avalonia
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args)
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterSingleton<IAppLayoutManager, AppLayoutManager>();
            unityContainer.RegisterSingleton<MainViewModel>();
            unityContainer.RegisterSingleton<ITrialLayoutFactory, TrialVersionFactory>();
            unityContainer.RegisterSingleton<ILeftPanelModel, LeftPanelModel>();
            unityContainer.RegisterSingleton<IFullVersionLayoutFactory, FullVersionFactory>();
            unityContainer.RegisterSingleton<IOnboardingLayoutFactory, OnboardingLayoutFactory>();

            ViewModelLocationProvider.Register<MainView>(() => unityContainer.Resolve<MainViewModel>());
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }
}
