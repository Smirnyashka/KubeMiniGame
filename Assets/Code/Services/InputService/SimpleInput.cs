using UnityEngine;

namespace Code.Services.InputService
{
    public class SimpleInput : IInput
    {
        public bool StartChangeDirection => Input.GetKeyDown(KeyCode.Space);
    }

    /*class TouchInput : IInput
    {
        public bool StartChangeDirection;
    }*/
}