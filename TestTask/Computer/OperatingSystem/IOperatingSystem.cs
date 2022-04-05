using TestTask.Commands;

namespace TestTask.Computer.OperatingSystem
{
    public interface IOperatingSystem
    {
        public void StartCommand(ICommand command);
        
        public void StopCommand(ICommand command);

        public TService GetServiceOfType<TService>();
    }
}