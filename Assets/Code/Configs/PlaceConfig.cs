using UnityEngine;

namespace Code.Configs
{
    public class PlaceConfig : MonoBehaviour
    {
        [SerializeField] private float _rightBorder;
        [SerializeField] private float _leftBorder;

        public float RightBorder => _rightBorder;
        public float LeftBorder => _leftBorder;
    }
}