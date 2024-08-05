using Code.Services.AssetProvider;
using Code.Services.Factories;
using Code.Units.Kubes;
using UnityEngine;
using Zenject;

namespace Code.Services.Pool
{
    public class CubePool: MonoBehaviour
    {
        private PoolMono<Cube> _pool;
        private GameFactory _factory;
        private AssetPathes _pathes;
        
        [SerializeField] private int _count;
        [SerializeField] private Transform _transform;

        [Inject]
        public void Construct(PoolMono<Cube> pool, GameFactory factory)
        {
            _factory = factory;
            _pool = new PoolMono<Cube>(_factory, _count, _transform, _pathes);
        }
    }
}