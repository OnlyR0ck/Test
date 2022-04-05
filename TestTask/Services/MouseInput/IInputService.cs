using System.Numerics;

namespace TestTask.Services.MouseInput
{
    public interface IInputService : IService
    {
        Vector2 GetInput();
    }
}