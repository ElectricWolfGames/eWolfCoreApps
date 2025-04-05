using CreateAudioVideos.Folder;
using System.Windows;
using System.Windows.Media;

namespace CreateAudioVideos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer _player = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VideoCreationData videoCreationData = new VideoCreationData();
            videoCreationData.MP3 = @"E:\Projects\GitHub\eWolfCoreApps\Tools\CreateAudioVideos\DemoData\DemoTack.mp3";
            videoCreationData.Image = @"E:\Projects\GitHub\eWolfCoreApps\Tools\CreateAudioVideos\DemoData\s04e01 Autumn Crocus.png";

            videoCreationData.PreSets();

            VideoCreation videoCreation = new VideoCreation(videoCreationData);
            videoCreation.Show();
        }
    }
}