using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class LinearFilter
    {
        public static void BlurImg(string location, string destination)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(location);
            Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int green = 0;
                    int red = 0;
                    int blue = 0;
                    int counter = 0;

                    for (int row = i - 1; row < i + 1; row++)
                    {
                        for (int col = j - 1; col < j + 1; col++)
                        {
                            if (row < 0)
                            {
                                continue;
                            }
                            else if (row >= bmp.Width)
                            {
                                continue;
                            }
                            else if (col < 0)
                            {
                                continue;
                            }
                            else if (col >= bmp.Height)
                            {
                                continue;
                            }
                            else
                            {
                                counter++;
                                Color pixel = bmp.GetPixel(row, col);
                                green += pixel.G;
                                red += pixel.R;
                                blue += pixel.B;
                            }
                        }
                    }

                    Color newPixel = Color.FromArgb((red / counter), (green / counter), (blue / counter));
                    newBmp.SetPixel(i, j, newPixel);
                }
            }
            newBmp.Save(destination);
        }

    }
}
