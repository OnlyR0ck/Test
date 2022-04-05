using System;
using TestTask.Computer.OperatingSystem;
using TestTask.Computer.SystemUnit;

namespace TestTask.Computer
{
    /*
     * TODO:
     * Здравствуйте, это главный класс, с которого я начинал проектировать модель.
     * При описании опирался на логику и на внутреннее устройство компьютера.
     * Решил сделать Computer чем-то вроде Фасада, так как по факту этим он и является, лишь
     * предоставляя интерфейс к своим внутренним деталям.
     * Также одним из плюсов Фасада является то, что он упрощает клиенту взаимодействие с системой
     *
     * Дальше - в ПК содержатся ссылки на OS и SU, которые предоставляют доступ к своим элементам и операциям.
     */
    public class Computer :  IComputer, ISaleable
    {
        private const string DefaultCharacteristics = "Super mega ultra horoshhh";
        private const int DefaultPrice = 228;
        
        private readonly ISystemUnit systemUnit;

        public IOperatingSystem OperatingSystem { get; }
        
        public string Id { get; private set; }

        
        public Computer(IOperatingSystem operatingSystem, ISystemUnit systemUnit)
        {
            OperatingSystem = operatingSystem;
            this.systemUnit = systemUnit;
            
            Id = Guid.NewGuid().ToString();
        }

        public float GetPrice() => DefaultPrice;
        

        public string GetCharacteristics() => DefaultCharacteristics;
    }
}