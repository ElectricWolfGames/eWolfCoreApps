using CommonCode;
using eWolfCommon.Helpers;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ThumbnailCreator.Helpers;

namespace ThumbnailCreator.DramaAudioEpisodes;

public partial class AudioDramaOneOffThumbnail : Window, INotifyPropertyChanged

{
    private int _indexCurrent = 0;
    private int _indexTotal;
    private string _outputPath = "";
    private string _showDescription = "";
    private string _showTitle = "Show Title";
    private string _showTitleLine2 = string.Empty;
    private string _storyType = string.Empty;

    public AudioDramaOneOffThumbnail()
    {
        InitializeComponent();

        DataContext = this;

        this.Loaded += Window_Loaded;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public int IndexCurrent
    {
        get => _indexCurrent;
        set
        {
            if (_indexCurrent != value)
            {
                _indexCurrent = value;
                OnPropertyChanged();
            }
        }
    }

    public int IndexTotal
    {
        get => _indexTotal;
        set
        {
            if (_indexTotal != value)
            {
                _indexTotal = value;
                OnPropertyChanged();
            }
        }
    }

    public string OutputPath
    {
        get { return _outputPath; }
        set
        {
            _outputPath = value;
            OnPropertyChanged();
        }
    }

    public string ShowDescription
    {
        get { return _showDescription; }
        set
        {
            _showDescription = value;
            OnPropertyChanged();
        }
    }

    public string ShowTitle
    {
        get { return _showTitle; }
        set
        {
            _showTitle = value;
            OnPropertyChanged();
        }
    }

    public string ShowTitleLine2
    {
        get { return _showTitleLine2; }
        set
        {
            _showTitleLine2 = value;
            OnPropertyChanged();
        }
    }

    public string StoryType
    {
        get { return _storyType; }
        set
        {
            _storyType = value;
            OnPropertyChanged();
        }
    }

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        Uri path = new(Path.Combine(_outputPath, $"{StringsHelper.MakeFileNameSafe(ShowTitle)}_thumbnail.png"));
        UIElement element = this.Content as UIElement;
        Screen.CaptureScreen(element, path);
        Close();
    }
}