using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Day02
{
    public class Point : IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point Move(int x, int y)
        {
            Point moved = new Point();
            moved.X = x + 1;
            moved.Y = y + 1;

            return moved;
        }
    }

    public abstract class Shapes : Point
    {
        public abstract void GetPerimeter();

        public abstract void GetArea();

    }

    public class Rectangle : Shapes
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int Center { get; set; }

        public override void GetPerimeter()
        {
            Console.WriteLine((2 * Width) + (2 * Height));
        }

        public override void GetArea()
        {
            Console.WriteLine(Width * Height);
        }
    }

    public class Square : Rectangle
    {
        public int Side { get; set; }

        public override int Width
        {
            get
            {
                return Side;
            }

            set
            {
                Side = value;
            }
        }

        public override int Height
        {
            get
            {
                return Side;
            }

            set
            {
                Side = value;
            }
        }

        public override void GetArea()
        {
            Console.WriteLine(Side * Side);
        }

        public override void GetPerimeter()
        {
            Console.WriteLine(4 * Side);
        }
    }
}
