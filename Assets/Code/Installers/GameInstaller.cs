using Code.Infrastructure;
using Zenject;

namespace Code.Installers
{
    public class GameInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameStateMachine>().AsSingle();
        }
    }
}