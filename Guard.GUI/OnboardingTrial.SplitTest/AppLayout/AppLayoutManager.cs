using System;
using Guard.Infrastructure;

namespace OnboardingTrial.SplitTest.AppLayout
{
    class AppLayoutManager : IAppLayoutManager
    {
        private readonly LayoutsFactory _layoutsFactory;
        public event Action<IAppLayout> CurrentLayoutChanged;
        public IAppLayout CurrentLayout { get; private set; }

        public AppLayoutManager(IApplicationState applicationState, LayoutsFactory layoutsFactory)
        {
            _layoutsFactory = layoutsFactory;
            CurrentLayout = layoutsFactory.CreateLayout(applicationState.CurrentState);
            applicationState.StateChanged += OnStateChanged;
        }

        private void OnStateChanged(AppState state)
        {
            CurrentLayout = _layoutsFactory.CreateLayout(state);
            CurrentLayoutChanged?.Invoke(CurrentLayout);
        }
    }

    internal class LayoutsFactory
    {
        public IAppLayout CreateLayout(AppState appState)
        {
            return new CommonViewModel(appState);
        }
    }

    internal class CommonViewModel : IAppLayout
    {
        public CommonViewModel(AppState appState)
        {
        }
    }
}