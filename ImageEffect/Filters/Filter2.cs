using AForge.Imaging.Filters;
using System;
using AForge.Imaging;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEffect.Filters
{
    public class Filter2 : IFilter
    {
        public UnmanagedImage Apply(UnmanagedImage image)
        {
            var bitmap = image.ToManagedImage();
            var outputBitmap = Apply(bitmap);
            return UnmanagedImage.FromManagedImage(outputBitmap);
        }

        public Bitmap Apply(BitmapData imageData)
        {
            throw new NotImplementedException();
        }

        public Bitmap Apply(Bitmap image)
        {
            var redRange = new AForge.IntRange(128, 255);
            var greenRange = new AForge.IntRange(0, 70);
            var blueRange = new AForge.IntRange(0, 70);
            var newImage = new Bitmap(image);
            for (var x = 0; x < image.Width; x++)
            {
                for (var y = 0; y < image.Height; y++)
                {
                    var color = image.GetPixel(x, y);
                    if (color.R >= redRange.Min && color.R <= redRange.Max
                        && color.G >= greenRange.Min && color.G <= greenRange.Max
                        && color.B >= blueRange.Min && color.B <= blueRange.Max)
                    {
                        newImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        newImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return newImage;
        }

        public void Apply(UnmanagedImage sourceImage, UnmanagedImage destinationImage)
        {
            throw new NotImplementedException();
        }

        private Bitmap MyEffect(Bitmap inputImage, int index, int total)
        {
            var width = inputImage.Width / total;
            var height = inputImage.Height;
            var rect = new Rectangle(index * width, 0, width, height);
            Crop filter = new Crop(rect);
            Bitmap result = filter.Apply(inputImage);
            return result;
        }
    }
}
