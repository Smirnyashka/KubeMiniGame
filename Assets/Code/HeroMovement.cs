using Code.Interfeces;
using Unity.VisualScripting;
using UnityEngine;

namespace Code
{
    public class HeroMovement : IMovement
    {
        private readonly Transform _transform;
        private Vector2 _direction = Vector2.right;

        public HeroMovement(Transform transform)
        {
            _transform = transform;
        }

        public Vector2 Move(float speed,  Vector2 direction)
        {
            Vector2 newPosition = _transform.position;
            
            newPosition += (speed * direction * Time.deltaTime);
            return newPosition;
        }
    }
}