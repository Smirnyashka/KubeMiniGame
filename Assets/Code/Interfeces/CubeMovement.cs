using UnityEngine;

namespace Code.Interfeces
{
    public class CubeMovement : IMovement
    {
        private readonly Transform _transform;
        private readonly Vector2 _center;

        public CubeMovement(Transform transform, Vector2 center)
        {
            _transform = transform;
            _center = center;
        }
        
        public Vector2 Move(float speed, Vector2 direction)
        {
            Vector2 newPosition = _transform.position;
            Vector2 offset = new Vector2(Random.Range(-2f, 2f), 0f);
            
            Debug.Log(offset);
            
            var normalized = (_center - newPosition + offset).normalized;

            newPosition += (speed * normalized * Time.deltaTime);
            return newPosition;
        }
    }
}