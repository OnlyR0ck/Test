namespace TestTask.Commands
{
    public interface ICommand
    {
        public void Execute();

        public void Cancel();
    }
}