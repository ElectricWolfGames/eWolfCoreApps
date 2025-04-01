using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ThumbnailCreator.Data;

namespace ThumbnailCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Thumbnails : Window, INotifyPropertyChanged
    {
        private bool _comedyShow = true;
        private SolidColorBrush _myColor = new SolidColorBrush(Colors.White);
        private bool _scifiShow = true;
        private ShowDetails _showDetails;

        public Thumbnails()
        {
            InitializeComponent();

            DataContext = this;

            _showDetails = Shows.PopulateShowData();
            this.Loaded += Window_Loaded;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsComedyShow
        {
            get => _comedyShow;
            set
            {
                if (_comedyShow != value)
                {
                    _comedyShow = value;
                    OnPropertyChanged(nameof(IsComedyShow));
                }
            }
        }

        public bool IsSciFiShow
        {
            get => _scifiShow;
            set
            {
                if (_scifiShow != value)
                {
                    _scifiShow = value;
                    OnPropertyChanged(nameof(IsSciFiShow));
                }
            }
        }

        public SolidColorBrush MyColor
        {
            get { return _myColor; }
            set { _myColor = value; OnPropertyChanged(nameof(MyColor)); }
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
                    Rect(new System.Windows.Point(0, 0), new System.Windows.Point(width, height)));
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

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CreateAll()
        {
            ShowTitle.Text = _showDetails.Title;
            IsComedyShow = _showDetails.ComdeyShow;
            IsSciFiShow = _showDetails.ScifiShow;

            if (IsSciFiShow)
                MyColor = new SolidColorBrush(Colors.White);
            if (IsComedyShow)
                MyColor = new SolidColorBrush(Colors.Yellow);

            var a = new SolidColorBrush(Colors.White);
            var b = new SolidColorBrush(Colors.Cyan);

            for (int seriesCount = 1; seriesCount < _showDetails.Series + 1; seriesCount++)
            {
                ShowType.Text = _showDetails.ShowTypeLineA;
                ShowType2.Text = _showDetails.ShowTypeLineB;
                Show.Text = $"Series {seriesCount}";

                var thumb = new BitmapImage(new Uri($"pack://application:,,,/{_showDetails.Source}"));
                Image.Source = thumb;

                int episodecount = _showDetails.EpisodeDetails.Where(x => x.Title.Contains($"s{seriesCount.ToString("D2")}")).Count();

                if (episodecount == 0)
                    EpisodeCount.Text = "One off show";
                else
                    EpisodeCount.Text = $"{episodecount} Episodes";

                if (_showDetails.CompleteShow)
                {
                    Show.Text = "Complete Show";
                }

                if (_showDetails.ShortShow)
                {
                    if (IsComedyShow)
                    {
                        Show.Text = "Short";
                    }
                    else
                    {
                        Show.Text = string.Empty;
                    }
                    EpisodeCount.Text = _showDetails.TitleLine2;
                }

                InvalidateVisual();
                UpdateLayout();

                Directory.CreateDirectory(_showDetails.Path);
                UIElement element = this.Content as UIElement;

                Directory.CreateDirectory(_showDetails.Path + "thumbnails\\");
                Uri path = new(_showDetails.Path + $"thumbnails\\{seriesCount}.png");
                if (_showDetails.ShortShow)
                {
                    path = new(_showDetails.Path + $"thumbnails\\{_showDetails.Title}.png");
                }

                CaptureScreen(element, path);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateAll();

            Close();
        }
    }
}