using Unity;

namespace Guard.Infrastructure.Extensions
{
    public static class UnityContainerExtension
    {
        public static void RegisterSingletons<TFrom1, TFrom2, TTo>(this IUnityContainer container)
            where TTo : TFrom1, TFrom2
        {
            container.RegisterSingleton<TTo>();
            container.RegisterFactory<TFrom1>(c => c.Resolve<TTo>());
            container.RegisterFactory<TFrom2>(c => c.Resolve<TTo>());
        }
    }
}