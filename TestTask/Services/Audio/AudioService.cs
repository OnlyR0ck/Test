using System;

namespace TestTask.Services.Audio
{
    public class AudioService : IAudioService
    {
        private const int MinVolume = 0;
        private const int MaxVolume = 100;
    
        private string currentSound;
        private int currentVolume = 0;

    
        public int Volume
        {
            get => currentVolume;
            set => currentVolume = currentVolume is >= MinVolume and <= MaxVolume ? 
                currentVolume = value : currentVolume;
        }


        public void PlayAudio(string name) => currentSound = name;

        public void StopAudio() => currentSound = String.Empty;
    }
}