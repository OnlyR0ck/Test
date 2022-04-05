namespace TestTask.Services.Audio
{
    public interface IAudioService : IService
    {
        public void PlayAudio(string name);
        public void StopAudio();

        public int Volume { get; set; }
    }
}