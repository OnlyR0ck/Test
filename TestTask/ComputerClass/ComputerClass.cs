using System.Collections.Generic;
using TestTask.Commands;
using TestTask.Computer;

namespace TestTask.ComputerClass
{
    /*TODO:
     1. Для установки ПО использовался паттерн Команда
     Да и вообще для любых действий. 
     Это позволяет полностью абстрагировать систему от того
     что она будет выполнять, тем самым получая более гибкое решение. 
     OperatingSystem.StartCommand 
     принимает на вход любой объект, реализующий интерфейс ICommand и запускает его на выполнение.
     Если смотреть глубже, то OS может делегировать команду какому-либо сервису, так как ещё одним 
     плюсом команды является то, что его можно передавать в параметры методам, возвращать из них 
     */
    public class ComputerClass : IComputerClass
    {
        private List<IComputer> computers;

        public ComputerClass()
        {
            computers = new List<IComputer>();
        }

        public void InstallSoftware(IComputer computer, ICommand softwareInstaller) => 
            computer.OperatingSystem.StartCommand(softwareInstaller);


        public void UninstallSoftware(IComputer computer, ICommand softwareUninstaller) =>
            computer.OperatingSystem.StartCommand(softwareUninstaller);
    }
}