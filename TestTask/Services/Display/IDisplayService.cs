namespace TestTask.Services.Display
{
    public interface IDisplayService : IService
    {
        void Update();
    }


    public class DisplayService : IDisplayService
    {
        private const int Frequency = 60;
    
    
        public void Update()
        {
        
        }
    }
}