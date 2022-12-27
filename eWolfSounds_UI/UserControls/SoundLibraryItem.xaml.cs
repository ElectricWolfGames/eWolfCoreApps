using eWolfSounds_UI.Interfaces;
using eWolfSounds_UI.Models;
using eWolfSounds_UI.Services;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace eWolfSounds_UI.UserControls
{
    public partial class SoundLibraryItem : UserControl, INotifyPropertyChanged
    {
        public SoundLibraryItem()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

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
                OnPropertyChanged("Title");
            }
        }

        public int TotalTags
        {
            get
            {
                return SoundDetails.GetTagHolders.CountTags();
            }
        }

        public void UpdateTags()
        {
            SoundDetails.UpdateTags();
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlayEffect();
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            // TODO: Remove item from the list
        }

        private void Button_OpenFolderClick(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", SoundDetails.PathOnly);
        }

        private void Label_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            PlayEffect();
        }

        private void PlayEffect()
        {
            var mps = ServiceLocator.Instance.GetService<MediaPlayerService>();
            mps.PlayEpisode(SoundDetails);
        }
    }
}