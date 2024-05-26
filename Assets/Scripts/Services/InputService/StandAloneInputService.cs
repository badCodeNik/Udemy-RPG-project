using UnityEngine;

namespace Services.InputService
{
    public class StandAloneInputService : InputService
    {
        public override Vector2 Axis
        {
            get
            {
                Vector2 axis = SimpleInputAxis();

                if (axis == Vector2.zero)
                    axis = UnityAxis();

                return axis;
            }
        }

        private static Vector2 UnityAxis() =>
            new(Input.GetAxis(Horizontal), Input.GetAxis(Vertical));
    }
}