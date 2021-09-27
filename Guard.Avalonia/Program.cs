using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using System;
using Guard.BL;
using Guard.BL.Factories;
using Guard.BL.Models;
using Guard.Infrastructure;
using Guard.Models;
using Prism.Mvvm;
using SplitTest.Common.Base.ViewModels;
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
