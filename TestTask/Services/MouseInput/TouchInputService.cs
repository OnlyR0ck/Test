using System.Numerics;

namespace TestTask.Services.MouseInput
{
    public class TouchInputService : IInputService
    {
        private Vector2 currentPosition;
        
        public Vector2 GetInput() => currentPosition;


        private void TouchPad_OnTap(Vector2 position) => currentPosition = position;
    }
}