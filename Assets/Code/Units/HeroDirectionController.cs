using System;
using Code.Configs;
using Code.Inpusts;
using UnityEngine;
using Zenject;

namespace Code.Units
{
    public class HeroDirectionController: MonoBehaviour, IInputHandler
    {
        private SimpleInput _input;
        private PlaceConfig _placeData;
        
        private Vector2 _direction = Vector2.right;

        public Vector2 Direction => _direction; 

        [Inject]
        public void Construct(SimpleInput input, PlaceConfig placeData)
        {
            _input = input;
            _placeData = placeData;
        }

        private void Update()
        {
            if(BoundCheck()) 
                ChangeDirection();
            if(_input.StartChangeDirection)
                ChangeDirection();
        }

        private bool BoundCheck()
        {
            if (_placeData == null)
                throw new NullReferenceException(nameof(_placeData));
            var positionX = transform.position.x;
            return _placeData.RightBorder < positionX || _placeData.LeftBorder > positionX;
        }

        private void ChangeDirection() => _direction = -_direction;
    }
}