using UnityEngine;

namespace Services.InputService
{
    public abstract class InputService : IInputService
    {
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";

        public abstract Vector2 Axis { get; }

        public bool IsAttackButtonUp() =>
            SimpleInput.GetButtonUp("Fire");

        protected static Vector2 SimpleInputAxis() =>
            new(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
    }
}