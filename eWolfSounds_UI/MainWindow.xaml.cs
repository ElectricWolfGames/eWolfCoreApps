using eWolfSounds_UI.Interfaces;
using eWolfSounds_UI.Models;
using eWolfSounds_UI.Services;
using eWolfSounds_UI.UserControls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace eWolfSounds_UI
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<SoundLibraryItem> _fullList = new ObservableCollection<SoundLibraryItem>();
        private SoundEffectHolder _soundEffectHolder = new SoundEffectHolder();
        private ObservableCollection<SoundLibraryItem> _soundItemsToShow = new ObservableCollection<SoundLibraryItem>();

        public MainWindow()
        {
            InitializeComponent();

            ServiceLocator.Instance.InjectService<MediaPlayerService>(new MediaPlayerService());

            _soundEffectHolder.Populate();
        }

        private void ButFixNames_Click(object sender, RoutedEventArgs e)
        {
            _soundEffectHolder.FixNames();

            MainItemsList.ItemsSource = GetSoundList();
        }

        private void ButSave_Click(object sender, RoutedEventArgs e)
        {
            _soundEffectHolder.RenameFiles();
        }

        private void ButSearch_Click(object sender, RoutedEventArgs e)
        {
            MainItemsList.Items.Clear();

            MainItemsList.ItemsSource = GetSoundList();
        }

        private void FilterText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            //string filter = FilterText.Text.ToUpper();

            ObservableCollection<SoundLibraryItem> items = new ObservableCollection<SoundLibraryItem>();
            foreach (var item in _fullList)
            {
                //  if (item.Title.ToUpper().Contains(filter))
                {
                    items.Add(item);
                }
            }
            MainItemsList.ItemsSource = items;
        }

        private ObservableCollection<SoundLibraryItem> GetSoundList()
        {
            ObservableCollection<SoundLibraryItem> items = new ObservableCollection<SoundLibraryItem>();

            List<ISoundDetails> sounds = _soundEffectHolder.Sounds;
            foreach (ISoundDetails sound in sounds)
            {
                SoundLibraryItem sli = new SoundLibraryItem
                {
                    SoundDetails = sound
                };
                items.Add(sli);
            }
            _fullList = items;
            return items;
        }
    }
}