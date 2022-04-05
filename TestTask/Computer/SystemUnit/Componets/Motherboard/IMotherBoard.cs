using System.Windows.Input;

namespace TestTask.Computer.SystemUnit
{
    public interface IMotherBoard
    {
        void CheckComponents();

        void AddComponent<TComponent>(IMotherBoardComponent component);
    }
}