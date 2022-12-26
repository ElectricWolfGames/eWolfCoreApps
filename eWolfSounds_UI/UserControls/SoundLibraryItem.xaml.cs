using eWolfSounds_UI.Models;
using eWolfSounds_UI.Interfaces;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace eWolfSounds_UI.UserControls
{
    /// <summary>
    /// Interaction logic for SoundLibraryItem.xaml
    /// </summary>
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
            /*Console.WriteLine("TODO: Start playing :" + Title);
            MediaPlayerService mps = ServiceLocator.Instance.GetService<MediaPlayerService>();
            mps.PlayEpisode(SoundDetails);*/
            var _mediaPlayer = new MediaPlayer();
            _mediaPlayer.Open(new Uri(SoundDetails.OrginalName));
            _mediaPlayer.Position = new TimeSpan(0);
            _mediaPlayer.Play();
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            // play the current sound effect
            //Console.WriteLine("TODO: Remove from the list :" + Title);
        }
    }
}