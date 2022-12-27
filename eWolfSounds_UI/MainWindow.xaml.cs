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

        private ObservableCollection<TagLibraryItem> _tagList = new ObservableCollection<TagLibraryItem>();

        public MainWindow()
        {
            InitializeComponent();

            ServiceLocator.Instance.InjectService<MediaPlayerService>(new MediaPlayerService());
            ServiceLocator.Instance.InjectService<MainWindow>(this);

            _soundEffectHolder.Populate();

            AddDefaultTags();
            MainTagList.ItemsSource = _tagList;
        }

        public void SetNewTagOnSelectedItem(string tagName)
        {
            var item = (SoundLibraryItem)MainItemsList.SelectedItem;
            if (item != null)
            {
                item.Title += $" {tagName}";
                item.UpdateTags();
            }
        }

        private void AddDefaultTags()
        {
            List<string> defaultTags = new List<string>();
            defaultTags.Add("Sci-Fi");
            defaultTags.Add("Background");
            defaultTags.Add("Machinery");
            defaultTags.Add("Human");
            defaultTags.Add("Animal");
            defaultTags.Add("Weather");
            defaultTags.Add("Transport");
            defaultTags.Add("Explosion");
            defaultTags.Add("War");

            foreach (string tag in defaultTags)
            {
                var tagItem = new TagLibraryItem()
                {
                    TagName = tag
                };
                _tagList.Add(tagItem);
            }
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
            //MainItemsList.Items.Clear();

            MainItemsList.ItemsSource = GetSoundList();
        }

        private ObservableCollection<SoundLibraryItem> GetSoundList()
        {
            bool untagged = Untagged.IsChecked == true;

            ObservableCollection<SoundLibraryItem> items = new ObservableCollection<SoundLibraryItem>();

            List<ISoundDetails> sounds = _soundEffectHolder.Sounds;
            foreach (ISoundDetails sound in sounds)
            {
                if (untagged)
                {
                    if (sound.TotalTags > 1)
                        continue;
                }
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