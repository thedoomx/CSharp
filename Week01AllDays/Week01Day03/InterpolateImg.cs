using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class InterpolateImg
    {
        public static void InterpolateImage(string bitmap, Size size, string location)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(bitmap);
            Bitmap newBmp = new Bitmap(size.Width, size.Height);
            double width = (bmp.Width - 1) / (newBmp.Width - 1);
            double height = (bmp.Height - 1) / (newBmp.Height - 1);

            for (int i = 0; i < newBmp.Width; i++)
            {
                for (int j = 0; j < newBmp.Height; j++)
                {

                    Color pixel = bmp.GetPixel((int)Math.Round(i * width), (int)Math.Round(j * height));
                    newBmp.SetPixel(i, j, pixel);
                }
            }

            newBmp.Save(location);
        }

    }
}
