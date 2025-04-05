using CreateAudioVideos.Folder;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace CreateAudioVideos
{
    public partial class VideoCreation : Window, INotifyPropertyChanged
    {
        private int _fadeTimeSeconds;
        private MediaPlayer _player = new MediaPlayer();
        private TimeSpan _startFade;

        public VideoCreation(VideoCreationData videoCreationData)
        {
            InitializeComponent();

            DataContext = this;

            MainImage = videoCreationData.Image;
            videoCreationData.Play();

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
    }
}