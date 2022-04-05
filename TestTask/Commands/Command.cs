using System;

namespace TestTask.Commands
{
    public abstract class Command : ICommand
    {
        public Action onComplete;
    
        public void Execute() => HandleStart();

        public void Cancel() => HandleCancel();


        protected abstract void HandleStart();
        protected abstract void HandleCancel();
    }
}