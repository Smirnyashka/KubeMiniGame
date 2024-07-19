using UnityEngine;
using Zenject;

namespace Code.Configs
{
    public class HeroConfig:MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Transform _position;

        public float Speed => _speed;
        public Transform Position => _position;
    }
}