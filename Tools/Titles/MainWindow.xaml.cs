using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Titles
{
    public partial class MainWindow : Window
    {
        public SolidColorBrush _fillColor = new SolidColorBrush(Colors.Yellow);
        private string _title = "Episode 2:\n\rLight and Track,\n\rand new Rolling Stock";

        // 120 episode fton size.
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public SolidColorBrush FillColor
        {
            get
            {
                return _fillColor;
            }
            set
            {
                _fillColor = value;
                OnPropertyChanged(nameof(FillColor));
            }
        }

        public string TitleLabel
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(TitleLabel));
                ShowTitle.Text = _title;
                OnPropertyChanged(nameof(ShowTitle));
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

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Directory.CreateDirectory("E:\\temp\\Titles\\");
            Uri path = new($"E:\\temp\\Titles\\title.png");
            UIElement element = this.Content as UIElement;
            CaptureScreen(element, path);
        }
    }
}