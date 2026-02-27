using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ThumbnailCreator.DramaAudioEpisodes;

public partial class AudioEpisodesShow : Window, INotifyPropertyChanged

{
    private int _indexCurrent = 0;
    private int _indexTotal;
    private string _outputPath = "";
    private string _seriesTitle = "";
    private string _showDescription = "";
    private string _showTitle = "Show Title";

    public AudioEpisodesShow()
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

    public static void CaptureScreen(UIElement source, Uri destination)
    {
        try
        {
            double height, renderHeight, width, renderWidth;

            height = renderHeight = source.RenderSize.Height;
            width = renderWidth = source.RenderSize.Width;

            //Specification for target bitmap like width/height pixel etc.
            RenderTargetBitmap renderTarget = new((int)renderWidth, (int)renderHeight, 0, 0,
                PixelFormats.Pbgra32);

            //creates Visual Brush of UIElement
            VisualBrush visualBrush = new(source);

            DrawingVisual drawingVisual = new();
            using (DrawingContext drawingContext =
            drawingVisual.RenderOpen())
            {
                //draws image of element
                drawingContext.DrawRectangle(visualBrush, null, new
                Rect(new Point(0, 0), new Point(width, height)));
            }
            //renders image
            renderTarget.Render(drawingVisual);

            //PNG encoder for creating PNG file
            PngBitmapEncoder encoder = new();
            encoder.Frames.Add(BitmapFrame.Create(renderTarget));
            using FileStream stream = new
                (destination.LocalPath, FileMode.Create,
            FileAccess.Write);
            encoder.Save(stream);
        }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString());
        }
    }

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void CreateAll()
    {
        /*ShowTitle.Text = _showDetails.Title;
        ShowDescription.Text = _showDetails.Description;

        BitmapImage thumb = new BitmapImage();
        thumb.BeginInit();
        thumb.UriSource = new Uri(_showDetails.Source, UriKind.Absolute);
        thumb.CacheOption = BitmapCacheOption.OnLoad; // Ensures the file is closed after loading
        thumb.EndInit();

        Image.Source = thumb;

        var a = new SolidColorBrush(Colors.White);
        var b = new SolidColorBrush(Colors.Cyan);

        foreach (var ep in _showDetails.EpisodeDetails)
        {
            ShowTitle.Text = _showDetails.Title + ep.TitleExtra;
            EpisodeTitle.Text = ep.Title;
            EpisodeDescription.Text = ep.Description;

            if (EpisodeTitle.Foreground == a)
            {
                EpisodeTitle.Foreground = b;
            }
            else
            {
                EpisodeTitle.Foreground = a;
            }

            InvalidateVisual();
            UpdateLayout();

            Directory.CreateDirectory(_showDetails.Path);
            UIElement element = this.Content as UIElement;

            string text = ep.Title;
            text = text.Replace(":", "");
            text = text.Replace("?", "");

            string subfolder = "OneOff";
            if (ep.Title.Length > 3)
                subfolder = ep.Title.Substring(0, 3);

            if (!string.IsNullOrWhiteSpace(ep.PartName))
            {
                subfolder = $"s{ep.StartName}{ep.PartName}";
            }

            Directory.CreateDirectory(_showDetails.Path + subfolder);

            if (_showDetails.ShortShow)
                text = _showDetails.Title;

            Uri path = new(_showDetails.Path + $"{subfolder}\\{text}.png");

            CaptureScreen(element, path);
        }*/
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        Uri path = new(Path.Combine(_outputPath, $"{ShowTitle}.png"));
        UIElement element = this.Content as UIElement;
        CaptureScreen(element, path);
        Close();
    }
}