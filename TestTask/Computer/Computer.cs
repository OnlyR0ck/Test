using System;
using TestTask.Computer.OperatingSystem;
using TestTask.Computer.SystemUnit;

namespace TestTask.Computer
{
    public class Computer :  IComputer, ISaleable
    {
        private readonly ISystemUnit systemUnit;

        public IOperatingSystem OperatingSystem { get; }
        
        public string Id { get; private set; }



        public Computer(IOperatingSystem operatingSystem, ISystemUnit systemUnit)
        {
            OperatingSystem = operatingSystem;
            this.systemUnit = systemUnit;
            
            Id = Guid.NewGuid().ToString();
        }

        public float GetPrice() => int.MaxValue;
        

        public string GetCharacteristics() => string.Empty;
    }
}