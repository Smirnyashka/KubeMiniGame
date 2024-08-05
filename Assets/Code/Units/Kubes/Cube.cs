using Code.Configs;
using Code.Interfeces;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Code.Units.Kubes
{
    public class Cube: MonoBehaviour, ICube, IMovable
    {
        [SerializeField] private float _spawnTime;
        [SerializeField] private float _speed;
        [SerializeField] private Vector2 _centerPoint = new Vector2(1.3f, -3f);

        private Vector2 offset;
        
        private IMovement _movement;
        private PlaceConfig _place;

        [Inject]
        public void Construct(PlaceConfig place)
        {
            _place = place;
            _movement = new CubeMovement(transform, _centerPoint, offset);
        }
        
        public void MoveToPoint()
        {
            gameObject.SetActive(true);
            transform.position = new Vector2(Random.Range(-2f, 5f), 5.5f);
            Setoffset();
        }


        private void Update()
        {
            if(Input.GetKeyUp(KeyCode.A)) MoveToPoint();
            transform.position = Move();
            
            if(transform.position.y < -2.9f) MoveToPoint();
        }

        private void Setoffset() => 
            offset = new Vector2(Random.Range(-2f, 2f), 0f);

        public Vector2 Move() => _movement.Move(_speed, Vector2.zero);

        // private Vector2 SetDirection()
        // {
        //     Vector2 offset = new Vector2(Random.Range(-2f, 2f), 0f);
        //     
        //     Vector2 newPosition = transform.position;
        //     return (_place.CenterPoint - newPosition + offset).normalized;
        // }
    }
}