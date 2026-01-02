using CreateAudioVideos.Folder;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace CreateAudioVideos
{
    public partial class VideoCreation : Window, INotifyPropertyChanged
    {
        private int _fadeTimeSeconds;
        private Process _ffmpegProcess;
        private MediaPlayer _player = new MediaPlayer();
        private TimeSpan _startFade;
        private Process process;

        public VideoCreation(VideoCreationData videoCreationData)
        {
            InitializeComponent();

            DataContext = this;

            MainImage = videoCreationData.Image;
            videoCreationData.Play();

            StartRecording();

            _fadeTimeSeconds = 5;
            _startFade = videoCreationData.Duration - new TimeSpan(0, 0, _fadeTimeSeconds * 2);

            var fadeInBlack = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = TimeSpan.FromSeconds(_fadeTimeSeconds),
            };

            fadeInBlack.Completed += StartHoldTime;
            BlackOverlay.BeginAnimation(UIElement.OpacityProperty, fadeInBlack);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string _mainImage { get; set; }

        public string MainImage
        {
            get
            {
                return _mainImage;
            }
            set
            {
                if (_mainImage != value)
                {
                    _mainImage = value;
                    NotifyChange(new PropertyChangedEventArgs("MainImage"));
                }
            }
        }

        private void NotifyChange(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        private void StartFadeToBlack(object? sender, EventArgs e)
        {
            var fadeInBlack = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(_fadeTimeSeconds),
            };
            fadeInBlack.Completed += StopVideo;
            BlackOverlay.BeginAnimation(UIElement.OpacityProperty, fadeInBlack);
        }

        private void StartHoldTime(object? sender, EventArgs e)
        {
            var fadeInBlack = new DoubleAnimation
            {
                From = 0,
                To = 0,
                Duration = _startFade,
            };

            fadeInBlack.Completed += StartFadeToBlack;
            BlackOverlay.BeginAnimation(UIElement.OpacityProperty, fadeInBlack);
        }

        private void StartRecording()
        {
            _ffmpegProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"E:\_Apps\ffmpeg\bin\ffmpeg.exe",
                    Arguments = "-i input.mp4 -vf scale=640:360 E:\\Projects\\GitHub\\eWolfCoreApps\\Tools\\CreateAudioVideos\\DemoData\\output.mp4", // example
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            _ffmpegProcess.Start();
        }

        private void StopVideo(object? sender, EventArgs e)
        {
            if (_ffmpegProcess != null && !_ffmpegProcess.HasExited)
            {
                _ffmpegProcess.Kill(); // force stop
                _ffmpegProcess.WaitForExit();
            }
        }
    }
}