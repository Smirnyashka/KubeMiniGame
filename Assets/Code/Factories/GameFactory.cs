using Code.Services.AssetProvider;
using UnityEngine;
using Zenject;

namespace Code.Factories
{
    public class GameFactory
    {
        private readonly Vector2 _spawnPoint = new Vector2(Random.Range(0, 5), Random.Range(0, 5));
        private readonly AssetProvider _asset;
        private readonly AssetPathes _path;

        public GameFactory(AssetProvider asset, AssetPathes path)
        {
            _asset = asset;
            _path = path;
        }

        public GameObject CreateBlackCube() =>
            _asset.Instantiate(_path.BlackKubePath, _spawnPoint);
        
        
        public GameObject CreateRedCube() =>
            _asset.Instantiate(_path.RedKubePath, _spawnPoint);
    }
}