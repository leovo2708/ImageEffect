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
            return MyEffect(image, 1, 8);
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
