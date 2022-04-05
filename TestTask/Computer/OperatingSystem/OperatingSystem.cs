using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TestTask.Commands;
using TestTask.Services;
using TestTask.Services.Audio;
using TestTask.Services.Display;
using TestTask.Services.MouseInput;

namespace TestTask.Computer.OperatingSystem
{
    public class OperatingSystem : IOperatingSystem
    {
        private Dictionary<Type, IService> services;
        
        public OperatingSystem() => RegisterServices();

        private void RegisterServices()
        {
            services = new Dictionary<Type, IService>()
            {
                {typeof(IAudioService), new AudioService()},
                {typeof(IDisplayService), new DisplayService()},
                {typeof(IDisplayService), FigureOutInputService()}
            };

        }

        public void StartCommand(ICommand command) => command.Execute();

        public void StopCommand(ICommand command) => command.Cancel();

        public TService GetServiceOfType<TService>() => (TService) services[typeof(TService)];

        private IService FigureOutInputService() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ?
                new MouseInputService() : new TouchInputService();
    }
}