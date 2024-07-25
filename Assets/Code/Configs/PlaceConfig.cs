using UnityEngine;

namespace Code.Configs
{
    public class PlaceConfig : MonoBehaviour
    {
        [SerializeField] private float _rightBorder;
        [SerializeField] private float _leftBorder;
        [SerializeField] private Vector2 _centerPoint;

        public float RightBorder => _rightBorder;
        public float LeftBorder => _leftBorder;
        public Vector2 CenterPoint => _centerPoint;
    }
}