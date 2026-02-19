using System.Windows;
using ThumbnailCreator.Creators;

namespace ThumbnailCreator;

public partial class Runner : Window
{
    public Runner()
    {
        InitializeComponent();

        CreateAudioDramaEpisodesShow createMissingShowData = new CreateAudioDramaEpisodesShow();
        createMissingShowData.CreateThumbnails();

        CreateAudioDramaOneOffShow createOneOffShowsData = new CreateAudioDramaOneOffShow();
        createOneOffShowsData.CreateThumbnails();

        Close();
    }
}