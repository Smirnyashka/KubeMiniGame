using Code.Services.StateMachine;

namespace Code.Factories
{
    public interface IStateFactory
    {
        public IState CreateState<TState>() where TState : IState;
    }
}