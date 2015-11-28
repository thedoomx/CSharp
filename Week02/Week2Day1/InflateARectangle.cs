using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1
{
    class InflateARectangle
    {
        public static void Inflate(ref Rectangle rect, Size inflateSize)
        {
            rect.X -= inflateSize.Width;
            rect.Y -= inflateSize.Height;
            rect.Width += inflateSize.Width * inflateSize.Width;
            rect.Height += inflateSize.Height * inflateSize.Height;
        }
    }
}
