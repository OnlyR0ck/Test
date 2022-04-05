public class Computer :  IComputer
{
    private readonly ISystemUnit systemUnit;

    public IOperatingSystem OperatingSystem { get; set; }
    

    public Computer(IOperatingSystem operatingSystem, ISystemUnit systemUnit)
    {
        OperatingSystem = operatingSystem;
        this.systemUnit = systemUnit;
    }
}