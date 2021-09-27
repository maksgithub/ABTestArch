using System;

namespace SplitTest.Common
{
    public readonly struct StateTransition<TState, TCommand> 
        where TState : struct, Enum
        where TCommand : struct, Enum
    {
        public readonly TState CurrentState { get; }
        public readonly TCommand Command { get; }

        public StateTransition(TState currentState, TCommand command)
        {
            CurrentState = currentState;
            Command = command;
        }
    }
}