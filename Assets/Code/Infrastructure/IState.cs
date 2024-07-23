namespace Code.Infrastructure
{
    public interface IState
    {
        public void Enter();
        public void Exit();
    }
}