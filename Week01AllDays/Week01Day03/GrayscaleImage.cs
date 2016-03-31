using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class GrayscaleImage
    {
        public static void GrayScaleImg(string bitmap, string location)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(bitmap);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    int color = (pixel.G + pixel.B + pixel.R) / 3;
                    Color newPixel = Color.FromArgb(color, color, color);
                    bmp.SetPixel(i, j, newPixel);
                }
            }

            bmp.Save(location);
        }
    }
}
