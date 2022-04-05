using System.Numerics;

namespace TestTask.Services.MouseInput
{
    public class MouseInputService : IInputService
    {
        private Vector2 currentPosition;

        public Vector2 GetInput() => currentPosition;

        private void Mouse_OnPress(Vector2 position) => currentPosition = position;

    }
}