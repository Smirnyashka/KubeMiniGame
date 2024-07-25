﻿using Zenject;
using Code.Services.StateMachine;

namespace Code.Factories
{
    public class StateFactory : IStateFactory
    {
        private readonly DiContainer _container;

        public StateFactory(DiContainer container) =>
            _container = container;

        public IState CreateState<TState>() where TState : IState =>
            _container.Resolve<TState>();
    }
}