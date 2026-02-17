using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using ThumbnailCreator.Helpers;

namespace ThumbnailCreator;

public partial class AudioEpisodesThumbnails : Window, INotifyPropertyChanged

{
    private int _indexCurrent = 0;
    private int _indexTotal;
    private string _outputPath = "";
    private string _seriesTitle = "";
    private string _seriesTitleLine2 = "";
    private string _showDescription = "";
    private string _showTitle = "Show Title";

    public AudioEpisodesThumbnails()
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

    public string SeriesTitle
    {
        get { return _seriesTitle; }
        set
        {
            _seriesTitle = value;
            OnPropertyChanged();
        }
    }

    public string SeriesTitleLine2
    {
        get { return _seriesTitleLine2; }
        set
        {
            _seriesTitleLine2 = value;
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

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        Uri path = new(Path.Combine(_outputPath, $"{ShowTitle}_Thumbnail.png"));
        UIElement element = this.Content as UIElement;
        Screen.CaptureScreen(element, path);
        Close();
    }
}