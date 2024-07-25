using Code.Services.SceneLoader;

namespace Code.Services.StateMachine.States
{
    class GameLoopState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly ISceneLoader _sceneLoader;

        public GameLoopState(GameStateMachine gameStateMachine, ISceneLoader sceneLoader)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            
        }

        public void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}