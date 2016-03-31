using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Point
    {
        private int x;
        private int y;
        private static Point origin = new Point(0, 0);

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(Point oldPoint)
        {
            x = oldPoint.x;
            y = oldPoint.y;
        }

        public int X
        {
            get
            {
                return x;
            }

            private set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            private set
            {
                y = value;
            }
        }

        public override string ToString()
        {
            return x + ", " + y;
        }

        public override bool Equals(object obj)
        {
            if ((obj as Point).X.Equals(x) && (obj as Point).Y.Equals(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Point a, Point b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Point a, Point b)
        {
            if (!a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static LineSegment operator +(Point a, Point b)
        {
            return new LineSegment(a, b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }
    }
}
