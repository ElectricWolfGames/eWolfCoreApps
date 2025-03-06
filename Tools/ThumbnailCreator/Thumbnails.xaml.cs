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
    public partial class Thumbnails : Window
    {
        private ShowDetails _showDetails;

        public Thumbnails()
        {
            InitializeComponent();

            _showDetails = Shows.PopulateStarShipData();
            this.Loaded += Window_Loaded;
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

        private void CreateAll()
        {
            ShowTitle.Text = _showDetails.Title;

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

                EpisodeCount.Text = $"{episodecount} Episodes";

                if (_showDetails.OneOffShow)
                {
                    Show.Text = "Short";
                    EpisodeCount.Text = _showDetails.TitleLine2;
                }

                InvalidateVisual();
                UpdateLayout();

                Directory.CreateDirectory(_showDetails.Path);
                UIElement element = this.Content as UIElement;

                Directory.CreateDirectory(_showDetails.Path + "thumbnails\\");
                Uri path = new(_showDetails.Path + $"thumbnails\\{seriesCount}.png");
                if (_showDetails.OneOffShow)
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