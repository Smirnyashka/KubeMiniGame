using System;
using Unity.VisualScripting;
using System.Collections.Generic;

namespace Code.Infrastructure
{
    public class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;
        private IState _activeState;

        public GameStateMachine(SceneLoader sceneLoader)
        {
            _states = new Dictionary<Type, IState>()
            {
                [typeof(GameLoopState)] = new GameLoopState(this, sceneLoader),
                [typeof(LoadingState)] = new LoadingState(this, sceneLoader)
            };
        }

        public void Enter<TState>() where TState : IState
        {
            _activeState?.Exit();
            IState state = _states[typeof(TState)];
            _activeState = state;
            state.Enter();
        }
    }
}