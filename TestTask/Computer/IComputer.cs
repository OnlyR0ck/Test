using TestTask.Computer.OperatingSystem;

namespace TestTask.Computer
{
    public interface IComputer
    {
        IOperatingSystem OperatingSystem { get; }
    }
}