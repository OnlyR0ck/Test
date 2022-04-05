using System.Collections.Generic;

namespace TestTask.Services.KeyboardService
{
    public class KeyboardInputService : IKeyboardInputService
    {
        private readonly Queue<int> keyboardBuffer;

        public KeyboardInputService()
        {
            keyboardBuffer = new Queue<int>();
        }

        public int GetInput() => keyboardBuffer.Dequeue();


        private void Keyboard_OnKeyPressed(int code) => keyboardBuffer.Enqueue(code);
    }
}