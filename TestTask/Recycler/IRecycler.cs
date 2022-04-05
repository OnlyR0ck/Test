using TestTask.Computer;

namespace TestTask.Recycler
{
    public interface IRecycler
    {
        bool TryRecycleItem(IComputer computer);
    }
}