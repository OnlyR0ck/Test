using System;
using System.Collections.Generic;
using TestTask.Commands;
using TestTask.Computer.OperatingSystem;

public class OperatingSystem : IOperatingSystem
{
    private Dictionary<Type, IService> services;
    
    public void StartCommand(ICommand command) => command.Execute();

    public void StopCommand(ICommand command) => command.Cancel();

    public TService GetServiceOfType<TService>() => (TService) services[typeof(TService)];
}