namespace TestTask.Commands
{
    public class CheckSuitabilityCommand : Command
    {
        public CheckSuitabilityCommand(out bool result)
        {
            result = false;
        }

        protected override void HandleStart()
        {
            //Get All Components and check their status
        }

        protected override void HandleCancel()
        {
            
        }
    }
}