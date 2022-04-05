using System.Collections.Generic;
using TestTask.Commands;
using TestTask.Computer;

namespace TestTask.Recycler
{
    public class Recycler
    {

        private readonly List<IComputer> savedComputers;

        public Recycler()
        {
            savedComputers = new List<IComputer>();
        }

        public bool TryRecycleItem(IComputer computer)
        {
            computer.OperatingSystem.StartCommand(new CheckSuitabilityCommand(out bool result));

            if (result)
            {
                TakeItForYourself(computer);
                return false;
            }

            RecycleItem(computer);
            return true;
        }

        private void RecycleItem(IComputer computer)
        {
            
        }

        private void TakeItForYourself(IComputer computer) => savedComputers.Add(computer);
    }
}