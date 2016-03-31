using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class LineSegment
    {
        private Point a;
        private Point b;

        public LineSegment(Point a, Point b)
        {
            if (a.Equals(b))
            {
                throw new ArgumentException("Cannot create a line segment with zero length.");
            }
            else
            {
                this.a = a;
                this.b = b;
            }
        }

        public LineSegment(LineSegment ab)
        {
            a = ab.a;
            b = ab.b;
        }

        public Point A
        {
            get
            {
                return a;
            }
        }

        public Point B
        {
            get
            {
                return b;
            }
        }

        public int GetLength()
        {
            return (int)Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public override string ToString()
        {
            return String.Format("Line[({0},{1}), ({2},{3})]", a.X, a.Y, b.X, b.Y);
        }

        public override bool Equals(object obj)
        {
            if ((obj as LineSegment).A.Equals(A) && (obj as LineSegment).B.Equals(B))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(LineSegment first, LineSegment second)
        {
            if (first.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(LineSegment first, LineSegment second)
        {
            if (!first.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(LineSegment first, LineSegment second)
        {
            if (first.GetLength() < second.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(LineSegment first, LineSegment second)
        {
            if (first.GetLength() > second.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(LineSegment first, LineSegment second)
        {
            if (first.GetLength() <= second.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(LineSegment first, LineSegment second)
        {
            if (first.GetLength() >= second.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(LineSegment ls, int length)
        {
            if (ls.GetLength() > length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(LineSegment ls, int length)
        {
            if (ls.GetLength() < length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(LineSegment ls, int length)
        {
            if (ls.GetLength() <= length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(LineSegment ls, int length)
        {
            if (ls.GetLength() >= length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + a.GetHashCode();
                hash = hash * 23 + b.GetHashCode();
                return hash;
            }
        }
    }
}
