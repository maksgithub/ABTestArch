using System;
using System.Collections.Generic;

namespace SplitTest.Common
{
    public abstract class BaseApplicationState<TState, TCommand> 
        where TState : struct, Enum
        where TCommand : struct, Enum
    {
        private Dictionary<StateTransition<TState, TCommand>, TState> _transitions;
        public TState CurrentState { get; private set; }
        protected IReadOnlyDictionary<StateTransition<TState, TCommand>, TState> Transitions => 
            _transitions ??= GetTransitions();

        public event Action<TState> StateChanged;

        protected BaseApplicationState(TState initialState)
        {
            CurrentState = initialState;
        }

        public TState MoveNext(TCommand command)
        {
            CurrentState = GetNext(command);
            StateChanged?.Invoke(CurrentState);
            return CurrentState;
        }

        protected abstract Dictionary<StateTransition<TState, TCommand>, TState> GetTransitions();

        private TState GetNext(TCommand command)
        {
            var transition = new StateTransition<TState, TCommand>(CurrentState, command);
            if (!Transitions.TryGetValue(transition, out var nextState))
                throw new Exception("Invalid transition: " + CurrentState + " -> " + command);
            return nextState;
        }
    }
}