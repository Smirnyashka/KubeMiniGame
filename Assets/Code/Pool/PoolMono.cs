using System.Collections.Generic;
using Code.Factories;
using Unity.VisualScripting;
using UnityEngine;

namespace Code.Pool
{
    public class PoolMono<T> where T : MonoBehaviour
    {

        private GameFactory _gameFactory;
        private Transform _container;
        private int _count;

        private Queue<T> _pool;

        public PoolMono(GameFactory gameFactory, int count, Transform container)
        {
            _gameFactory = gameFactory;
            _container = container;
            CreatePool(count);
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
            GameObject createdObject = _gameFactory.CreateBlackCube();
            createdObject.SetActive(isActiveByDefault);
            _pool.Enqueue(createdObject as T);
            return GetFreeElement();
        }

        public T GetFreeElement()
        {
            if (HasFreeElement(out var element))
                return element;

            throw new System.Exception($"there is no free element in pool of type {typeof(T)}");
        }

        private bool HasFreeElement(out T element)
        {
            foreach (var mono in _pool)
            {
                if (!mono.gameObject.activeInHierarchy)
                {
                    element = mono;
                    element.gameObject.SetActive(true);
                    return true;
                }
            }
            element = null;
            return false;
        }



    }
}
