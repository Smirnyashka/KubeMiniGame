using System;
using Code.Configs;
using Code.Services.InputService;
using UnityEngine;
using Zenject;

namespace Code.Units
{
    public class Direction
    {
        private IInput _input;
        private PlaceConfig _placeData;
        
        private Vector2 _direction = Vector2.right;
        
        public Direction(IInput input, PlaceConfig placeData)
        {
            _input = input;
            _placeData = placeData;
        }

        public Vector2 Get(Transform transform)
        {
            if (_placeData == null)
                throw new NullReferenceException(nameof(_placeData));
            
            var positionX = transform.position.x;
            
            if(_placeData.RightBorder < positionX || _placeData.LeftBorder > positionX) 
                Change();

            if (_input.StartChangeDirection)
                Change();

            return _direction;
        }

        private void Change() => _direction = -_direction;
    }
}