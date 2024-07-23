namespace Code.Infrastructure
{
    class LoadingState : IState
    {
        private GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;

        public LoadingState(GameStateMachine stateMachine, SceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }
        
        public void Enter()
        {
            _sceneLoader.LoadScene("SampleScene");
        }

        public void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}