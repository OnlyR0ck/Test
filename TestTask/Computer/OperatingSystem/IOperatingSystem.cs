public interface IOperatingSystem
{
    public void StartCommand(ICommand command);
    
    public TService GetServiceOfType<TService>();
}