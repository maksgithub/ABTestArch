using System;
using System.Collections.Generic;
using SplitTest.Common;

namespace OnboardingTrial.SplitTest.AppLayout
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
                { new StateTransition<AppState, AppCommand>(AppState.Onboarding, AppCommand.FinishOnboarding), AppState.Trial},
                { new StateTransition<AppState, AppCommand>(AppState.Trial, AppCommand.StartLogin), AppState.Login},
                { new StateTransition<AppState, AppCommand>(AppState.Login, AppCommand.FinishLogin), AppState.LoggedIn},
                { new StateTransition<AppState, AppCommand>(AppState.Login, AppCommand.FinishLoginLicense), AppState.Full},
            };
        }
    }

    internal interface IApplicationState
    {
        AppState CurrentState { get; }
        event Action<AppState> StateChanged;
    }
}
