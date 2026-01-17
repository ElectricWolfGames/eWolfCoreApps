using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Titles.Helpers;

namespace Titles;

public partial class MainWindow : Window
{
    // nice font - Montserrat Subrayada

    public SolidColorBrush _fillColor = new SolidColorBrush(Colors.Yellow);
    private string _titleA = "Episode 2:";
    private string _titleB = "Light and Track,\n\r+ Rolling Stock";

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
        get { return _titleA; }
        set
        {
            _titleA = value;
            OnPropertyChanged(nameof(TitleLabel));
            ShowTitle.Text = _titleA;
            OnPropertyChanged(nameof(ShowTitle));
        }
    }

    public string TitleLabelB
    {
        get { return _titleB; }
        set
        {
            _titleB = value;
            OnPropertyChanged(nameof(TitleLabelB));
            ShowTitleB.Text = _titleB;
            OnPropertyChanged(nameof(ShowTitleB));
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
        string basePath = "E:\\temp\\Titles\\";
        Directory.CreateDirectory(basePath);
        Uri path = new($"{basePath}\\title.png");

        UIElement element = (UIElement)this.Content;
        CaptureScreen(element, path);

        WindowsHelper.OpenFileExplorer(basePath);
    }
}