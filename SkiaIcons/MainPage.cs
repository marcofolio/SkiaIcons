using System;
using SkiaSharp;
using SkiaSharp.Extended.Iconify;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace SkiaIcons
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Xamarin.Forms with SkiaSharp Iconify";

            var grid = new Grid();

            var canvas = new SKCanvasView();
            canvas.PaintSurface += OnPainting;

            grid.Children.Add(canvas);

            this.Content = grid;
        }

        private void OnPainting(object sender, SKPaintSurfaceEventArgs e)
        {
            var surface = e.Surface;
            var canvas = surface.Canvas;

            var text = "Use {{fa-font-awesome color=4189DF}} to {{fa-paint-brush}} some {{fa-thumbs-up color=3B5998}} icons that you'll {{fa-heart color=ff0000}}!";

            using (var textPaint = new SKPaint())
            {
                textPaint.IsAntialias = true;
                textPaint.TextSize = 48;
                textPaint.Typeface = SKTypeface.FromFamilyName("Arial");

                var padding = 24;
                var yOffset = padding + textPaint.TextSize;

                canvas.DrawIconifiedText(text, padding, yOffset, textPaint);
            }
        }
    }
}
