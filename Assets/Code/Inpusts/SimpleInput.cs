using System;
using Code.Interfeces;
using UnityEngine;

namespace Code.Inpusts
{
    public class SimpleInput
    {
        public bool StartChangeDirection => Input.GetKeyDown(KeyCode.Space);
    }
}