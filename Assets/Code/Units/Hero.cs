using System;
using System.Threading.Tasks;
using Code.Configs;
using Code.Interfeces;
using Code.Services.InputService;
using UnityEngine;
using Zenject;

namespace Code.Units
{
    public class Hero : MonoBehaviour, IMovable
    {
        private HeroConfig _data;
        private IMovement _movement;
        private Direction _heroDirection;

        [Inject]
        public void Construct(HeroConfig data, Direction heroDirection)
        {
            _data = data;
            _heroDirection = heroDirection;
            _movement = new HeroMovement(_data.Position);
        }

        public Vector2 Move() => 
            _movement.Move(_data.Speed, _heroDirection.Get(transform));

        private void Update() => 
            transform.position = Move();
    }
}