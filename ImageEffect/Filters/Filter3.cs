using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageEffect.Filters
{
    public class Filter3 : IFilter
    {
        public Bitmap Apply(Bitmap image)
        {
            byte minRed = 255;
            Point minRedPoint = new Point(0, 0);
            byte maxRed = 0;
            Point maxRedPoint = new Point(0, 0);

            byte minGreen = 255;
            Point minGreenPoint = new Point(0, 0);
            byte maxGreen = 0;
            Point maxGreenPoint = new Point(0, 0);

            byte minBlue = 255;
            Point minBluePoint = new Point(0, 0);
            byte maxBlue = 0;
            Point maxBluePoint = new Point(0, 0);

            for (var x = 0; x < image.Width; x++)
            {
                for (var y = 0; y < image.Height; y++)
                {
                    var color = image.GetPixel(x, y);
                    if (color.R != 255 && color.G != 255 && color.B != 255)
                    {
                        var point = new Point(x, y);
                        var newMinRed = Math.Min(minRed, color.R);
                        if (minRed != newMinRed)
                        {
                            minRedPoint = point;
                        }
                        minRed = newMinRed;

                        var newMaxRed = Math.Max(maxRed, color.R);
                        if (maxRed != newMaxRed)
                        {
                            maxRedPoint = point;
                        }
                        maxRed = newMaxRed;

                        var newMinGreen = Math.Min(minGreen, color.G);
                        if (minGreen != newMinGreen)
                        {
                            minGreenPoint = point;
                        }
                        minGreen = newMinGreen;

                        var newMaxGreen = Math.Max(maxGreen, color.G);
                        if (maxGreen != newMaxGreen)
                        {
                            maxGreenPoint = point;
                        }
                        maxGreen = newMaxGreen;

                        var newMinBlue = Math.Min(minBlue, color.B);
                        if (minBlue != newMinBlue)
                        {
                            minBluePoint = point;
                        }
                        minBlue = newMinBlue;

                        var newMaxBlue = Math.Max(maxBlue, color.B);
                        if (maxBlue != newMaxBlue)
                        {
                            maxBluePoint = point;
                        }
                        maxBlue = newMaxBlue;
                    }
                }
            }

            var lines = new List<string>();
            lines.Add($"Red: {minRed}({minRedPoint}) - {maxRed}({maxRedPoint})");
            lines.Add($"Green: {minGreen}({minGreenPoint}) - {maxGreen}({maxGreenPoint})");
            lines.Add($"Blue: {minBlue}({minBluePoint}) - {maxBlue}({maxBluePoint})");
            var message = string.Join(Environment.NewLine, lines);
            MessageBox.Show(message);
            return image;
        }

        public Bitmap Apply(BitmapData imageData)
        {
            throw new NotImplementedException();
        }

        public UnmanagedImage Apply(UnmanagedImage image)
        {
            var bitmap = image.ToManagedImage();
            var outputBitmap = Apply(bitmap);
            return UnmanagedImage.FromManagedImage(outputBitmap);
        }

        public void Apply(UnmanagedImage sourceImage, UnmanagedImage destinationImage)
        {
            throw new NotImplementedException();
        }
    }
}
