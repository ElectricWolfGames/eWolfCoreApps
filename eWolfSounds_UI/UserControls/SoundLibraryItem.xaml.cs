using eWolfSounds_UI.Interfaces;
using eWolfSounds_UI.Models;
using eWolfSounds_UI.Services;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace eWolfSounds_UI.UserControls
{
    public partial class SoundLibraryItem : UserControl
    {
        public SoundLibraryItem()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string Path
        {
            get
            {
                return SoundDetails.FullPath;
            }
        }

        public string PathOnly
        {
            get
            {
                return SoundDetails.FullPath;
            }
        }

        public ISoundDetails SoundDetails { get; set; } = new SoundDetails();

        public string Title
        {
            get
            {
                return SoundDetails.Name;
            }
            set
            {
                SoundDetails.Name = value;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayerService mps = ServiceLocator.Instance.GetService<MediaPlayerService>();
            mps.PlayEpisode(SoundDetails);
            /*var _mediaPlayer = new MediaPlayer();
            _mediaPlayer.Open(new Uri(SoundDetails.OrginalName));
            _mediaPlayer.Position = new TimeSpan(0);
            _mediaPlayer.Play();*/
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            // play the current sound effect
            //Console.WriteLine("TODO: Remove from the list :" + Title);
        }

        private void Button_OpenFolderClick(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", SoundDetails.PathOnly);
        }
    }
}