using NAudio.Wave;
using System.Windows.Media;

namespace CreateAudioVideos.Folder
{
    public class VideoCreationData
    {
        private MediaPlayer _player = new MediaPlayer();
        public TimeSpan Duration { get; set; }
        public string Image { get; set; }
        public bool Loaded { get; set; }
        public string MP3 { get; set; }
        public string Title { get; set; }

        internal void Play()
        {
            _player.Open(new Uri(MP3, UriKind.Absolute));
            _player.Volume = 0.5;
            _player.Play();
        }

        internal void PreSets()
        {
            using (var reader = new Mp3FileReader(MP3))
            {
                Duration = reader.TotalTime;
            }
        }
    }
}