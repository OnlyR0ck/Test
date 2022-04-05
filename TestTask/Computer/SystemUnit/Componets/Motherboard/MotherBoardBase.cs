namespace TestTask.Computer.SystemUnit
{
    public abstract class MotherBoardBase : IMotherBoard, IComponent
    {
        public abstract void CheckComponents();

        public abstract void AddComponent<TComponent>(IMotherBoardComponent component);
    }
}