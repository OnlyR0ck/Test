using System.Numerics;

namespace TestTask.Services.MouseInput
{
    public interface IMouseInputService : IService
    {
        Vector2 GetInput();
    }

    public class TouchInputService : IMouseInputService
    {
        
    }
}