using System;

namespace TestTask.Commands
{
    public abstract class Command : ICommand
    {
        public Action onComplete;
    
        public virtual void Execute()
        {
        
        }

        public virtual void Cancel()
        {
        
        }
    }
}