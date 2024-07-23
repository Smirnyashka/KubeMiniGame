using System;
using System.Threading.Tasks;
using Code.Configs;
using Code.Interfeces;
using UnityEngine;
using Zenject;

namespace Code.Units
{
    public class Hero : MonoBehaviour, IMovable, IInputHandler
    {
        private HeroConfig _data;
        private IMovement _movement;
        private HeroDirectionController _heroDirection;

        [Inject]
        public void Construct(HeroConfig data, IMovement movement, HeroDirectionController heroDirection)
        {
            _data = data;
            _movement = movement;
            _heroDirection = heroDirection;
            _movement = new SimpleMovement();
        }

        public Vector2 Move() => _movement.Move(_data.Speed, _data.Position, _heroDirection.Direction);

        private async void Update()
        {
            await WriteData();
            transform.position = Move();
        }

        private async Task WriteData()
        {
            Debug.Log("fffffff");
            for(int i =0; i< 10; i++) Debug.Log(i);
            await Task.Yield();
        }
    }

    public interface IInputHandler
    {
    }
}