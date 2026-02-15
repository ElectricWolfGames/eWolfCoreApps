using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ThumbnailCreator.Helpers;

internal static class Screen
{
    internal static void CaptureScreen(UIElement source, Uri destination)
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
}