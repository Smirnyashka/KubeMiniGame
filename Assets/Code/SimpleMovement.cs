using Code.Interfeces;
using Unity.VisualScripting;
using UnityEngine;

namespace Code
{
    public class SimpleMovement: IMovement
    {
        private Vector2 _direction = Vector2.right;

        public Vector2 Move(float speed, Transform transform, Vector2 direction)
        {
            Vector2 newPosition = transform.position;
            
            newPosition += (speed * direction * Time.deltaTime);
            return newPosition;
        }
    }
}