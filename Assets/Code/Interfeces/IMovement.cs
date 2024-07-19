﻿using UnityEngine;

namespace Code.Interfeces
{
    public interface IMovement
    {
        public Vector2 Move(float speed, Transform transform, Vector2 direction);
    }
}