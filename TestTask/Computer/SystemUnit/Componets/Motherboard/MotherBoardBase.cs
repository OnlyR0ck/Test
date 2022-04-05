namespace TestTask.Computer.SystemUnit
{
    public abstract class MotherBoardBase : IMotherBoard, IComponent
    {
        public abstract bool CheckComponents();

        public abstract void AddComponent<TComponent>(IMotherBoardComponent component);
    }
}