using System;
using System.Collections.Generic;
using Guard.Infrastructure;
using SplitTest.Common;

namespace LoginFullVersion.SplitTest.AppLayout
{
    internal class ApplicationState : BaseApplicationState<AppState, AppCommand>, IApplicationState
    {
        public ApplicationState() : base(AppState.LoggedOut)
        {
        }

        protected override Dictionary<StateTransition<AppState, AppCommand>, AppState> GetTransitions()
        {
            return new Dictionary<StateTransition<AppState, AppCommand>, AppState>()
            {
                { new StateTransition<AppState, AppCommand>(AppState.LoggedOut, AppCommand.StartLogin), AppState.FullVersion },
                { new StateTransition<AppState, AppCommand>(AppState.FullVersion, AppCommand.ExitAccount), AppState.LoggedOut}
            };
        }
    }
}
