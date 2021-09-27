using System;
using LoginFullVersion.SplitTest.AppLayout;

namespace LoginFullVersion.SplitTest
{
    internal interface IApplicationState
    {
        AppState CurrentState { get; }
        AppState MoveNext(AppCommand command);
        event Action<AppState> StateChanged;
    }
}