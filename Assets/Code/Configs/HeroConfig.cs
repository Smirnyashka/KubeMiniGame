using UnityEngine;
using Zenject;

namespace Code.Configs
{
    public class HeroConfig
    {
        private float _speed = 4f;

        public float Speed => _speed;
    }
}