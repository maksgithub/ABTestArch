using System;
using Guard.Infrastructure;
using LoginFullVersion.SplitTest.AppLayout;

namespace LoginFullVersion.SplitTest.Layouts.LayoutsFactory
{
    class LayoutsFactory
    {
        private readonly IApplicationState _applicationState;

        internal LayoutsFactory(IApplicationState applicationState)
        {
            _applicationState = applicationState;
        }

        public IAppLayout CreateLayout(AppState currentState)
        {
            return currentState switch
            {
                AppState.LoggedOut => new LoginLayoutViewModel(_applicationState),
                AppState.FullVersion => new FullVersionLayoutViewModel(_applicationState),
                _ => throw new ArgumentOutOfRangeException(nameof(currentState), currentState, null)
            };
        }
    }
}