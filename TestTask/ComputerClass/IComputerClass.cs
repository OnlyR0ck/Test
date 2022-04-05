using TestTask.Commands;
using TestTask.Computer;

namespace TestTask.ComputerClass
{
    public interface IComputerClass
    {
        void InstallSoftware(IComputer computer, ICommand softwareInstaller);
        void UninstallSoftware(IComputer computer, ICommand softwareUninstaller);
    }
}