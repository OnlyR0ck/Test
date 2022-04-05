using System.Windows.Input;

namespace TestTask.Computer.SystemUnit
{
    public interface IMotherBoard
    {
        bool CheckComponents();

        void AddComponent<TComponent>(IMotherBoardComponent component);
    }
}