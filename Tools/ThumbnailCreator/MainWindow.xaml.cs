﻿using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using ThumbnailCreator.Data;
using System.Xml.Linq;

namespace ThumbnailCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ShowDetails _showDetails;

        public MainWindow()
        {
            InitializeComponent();

            _showDetails = Shows.PopulateStarShipData();
            this.Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateAll();

            Thumbnails thumbnails = new Thumbnails();
            thumbnails.ShowDialog();
            Close();
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
            ShowDescription.Text = _showDetails.Description;

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

                Directory.CreateDirectory(_showDetails.Path + "Images\\");

                Uri path = new(_showDetails.Path + $"Images\\{text}.png");
                CaptureScreen(element, path);
            }




        }
    }
}