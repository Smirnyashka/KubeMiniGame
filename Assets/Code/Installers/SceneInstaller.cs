using Code.Configs;
using Code.Interfeces;
using Code.Services.InputService;
using Code.Units;
using UnityEngine;
using Zenject;

namespace Code.Installers
{
    public class SceneInstaller : MonoInstaller
    {

        [SerializeField] private HeroConfig _config;
        [SerializeField] private Hero _hero;
        [SerializeField] private PlaceConfig _placeConfig;

        public override void InstallBindings()
        {
             BindUnits();
             BindServices();
             BindConfigs();
        }

        private void BindConfigs()
        {
            Container.Bind<PlaceConfig>().FromInstance(_placeConfig).AsSingle();
            Container.Bind<HeroConfig>().FromInstance(_config).AsSingle();
        }

        private void BindUnits()
        {
            Container.Bind<Hero>().FromInstance(_hero).AsSingle();
        }

        private void BindServices()
        {
            Container.Bind<Direction>().AsSingle();
            Container.Bind<IInput>().To<SimpleInput>().AsSingle();
        }
    }
}