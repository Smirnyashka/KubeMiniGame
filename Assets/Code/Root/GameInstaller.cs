using Code.Services.AssetProvider;
using Code.Services.Factories;
using Code.Services.SceneLoader;
using Code.Services.StateMachine;
using Zenject;

namespace Code.Root
{
    public class GameInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            BindFactories();
            BindAssetProvider();
            BindSceneLoader();
            BindStateMachine();
        }

        private void BindSceneLoader() => 
            Container.BindInterfacesAndSelfTo<SceneLoader>().AsSingle();

        private void BindAssetProvider()
        {
            Container.BindInterfacesAndSelfTo<AssetPathes>().AsSingle();
            Container.BindInterfacesAndSelfTo<AssetProvider>().AsSingle();
        }

        private void BindFactories()
        {
            Container.BindInterfacesAndSelfTo<GameFactory>().AsSingle();
            Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
        }

        private void BindStateMachine() => 
            Container.BindInterfacesAndSelfTo<GameStateMachine>().AsCached();
    }
}