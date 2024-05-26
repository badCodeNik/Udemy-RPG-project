using UnityEngine;

namespace Services.InputService
{
    public interface IInputService
    {
        public Vector2 Axis { get; }
        public bool IsAttackButtonUp();
    }
}