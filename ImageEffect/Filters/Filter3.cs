using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEffect.Filters
{
    public class Filter3 : IFilter
    {
        public Bitmap Apply(Bitmap image)
        {
            var blobCounter = new BlobCounter();
            //blobCounter.BackgroundThreshold = Color.White;
            blobCounter.ProcessImage(image);
            var blobs = blobCounter.GetObjects(image, false);
            Bitmap bitmap = MainForm.DrawBitmapsAlignBottom((
                from blob in blobs
                select blob.Image.ToManagedImage()).ToList<Bitmap>());
            return bitmap;
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
