using System.Collections.Generic;
using Code.Services.AssetProvider;
using Code.Services.Factories;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Services.Pool
{
    public class PoolMono<T> where T: MonoBehaviour
    {
        private GameFactory _gameFactory;
        private Transform _container;
        private AssetPathes _pathes;

        private Queue<T> _pool;

        public PoolMono(GameFactory gameFactory, int count, Transform container, AssetPathes pathes)
        {
            _gameFactory = gameFactory;
            _container = container;
            _pathes = pathes;
            CreatePool(count);
        }

        public async UniTask Initialize(int count, Transform container = null)
        {
            _container = container;

            await CreatePool(count);
        }


        private Queue<T> CreatePool(int count)
        {
            _pool = new Queue<T>();

            for (int i = 0; i < count; i++)
            {
                CreateObject();
            }

            return _pool;
        }

        private T CreateObject(bool isActiveByDefault = false)
        {
            var item = _gameFactory.Create<T>(_pathes.RedKubePath);
            item.SetActive(isActiveByDefault);
            item.transform.SetParent(_container);
            _pool.Enqueue(item);
            return item;
        }

        public GameObject GetFreeElement()
        {
            if (HasFreeElement(out var element))
                return element;

            throw new System.Exception($"there is no free element in pool of type {typeof(GameObject)}");
        }

        private bool HasFreeElement(out T element)
        {
            foreach (var mono in _pool)
            {
                if (!mono.gameObject.activeInHierarchy)
                {
                    element = mono;
                    mono.gameObject.SetActive(true);
                    return true;
                }
            }

            element = null;
            return false;
        }
    }
}