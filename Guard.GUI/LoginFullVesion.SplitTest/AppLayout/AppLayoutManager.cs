using System;
using Guard.Infrastructure;
using LoginFullVersion.SplitTest.Layouts.LayoutsFactory;

namespace LoginFullVersion.SplitTest.AppLayout
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
}