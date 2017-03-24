using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using AForge.Imaging;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEffect.Filters
{
    public class Filter1 : IFilter
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
            var outputImage = ColorRangeExtract(image, 215, 16, 22, 70);
            return BlobExtract(outputImage);
        }

        public void Apply(UnmanagedImage sourceImage, UnmanagedImage destinationImage)
        {
            throw new NotImplementedException();
        }

        private Bitmap ColorRangeExtract(Bitmap image, int red, int green, int blue, int delta)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    result.SetPixel(x, y, Color.Black);
                    Color pixelColor = image.GetPixel(x, y);
                    if ((red + delta < pixelColor.R ? false : red - delta <= pixelColor.R))
                    {
                        if ((green + delta < pixelColor.G ? false : green - delta <= pixelColor.G))
                        {
                            if ((blue + delta < pixelColor.B ? false : blue - delta <= pixelColor.B))
                            {
                                result.SetPixel(x, y, Color.White);
                            }
                        }
                    }
                }
            }
            return result;
        }

        private Bitmap BlobExtract(Bitmap image)
        {
            var blobCounter = new BlobCounter()
            {
                ObjectsOrder = ObjectsOrder.XY
            };
            blobCounter.ProcessImage(image);
            Bitmap bitmap = MainForm.DrawBitmapsAlignBottom((
                from blob in (IEnumerable<Blob>)blobCounter.GetObjects(image, false)
                select blob.Image.ToManagedImage()).ToList<Bitmap>());
            return bitmap;
        }
    }
}
