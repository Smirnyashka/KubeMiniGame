using System;
using Code.Interfeces;
using UnityEngine;

namespace Code.Inpusts
{
    public class SimpleInput: IInput
    {
        public bool StartChangeDirection => Input.GetKeyDown(KeyCode.Space);
    }

    public interface IInput
    {
    }

    class TouchInput : IInput
    {
        public bool StartChangeDirection;
    }
}