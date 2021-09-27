using Guard.Infrastructure;
using Guard.Infrastructure.Extensions;
using LoginFullVersion.SplitTest.AppLayout;
using LoginFullVersion.SplitTest.Layouts.LayoutsFactory;
using Unity;

namespace LoginFullVersion.SplitTest.Extensions
{
    public static class UnityContainerExtension
    {
        public static void RegisterLoginFullVersionSplitTest(this IUnityContainer container)
        {
            container.RegisterSingleton<IApplicationState, ApplicationState>();
            container.RegisterSingleton<IAppLayoutManager, AppLayoutManager>();
            container.RegisterSingleton<LayoutsFactory>();
        }
    }
}