using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Rectangle
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        public Rectangle(Point first, Point second)
        {
            if (first.X == second.X || first.Y == second.Y)
            {
                throw new ArgumentException("The points cannot be on the same coordinate axis.");
            }
            else
            {
                this.a = first;
                this.c = second;
                this.b = new Point(second.X, first.Y);
                this.d = new Point(first.X, second.Y);
            }
        }

        public Rectangle(Rectangle original)
        {
            this.a = original.a;
            this.b = original.b;
            this.c = original.c;
            this.d = original.d;
        }

        public Point A
        {
            get
            {
                return this.a;
            }
        }

        public Point B
        {
            get
            {
                return this.b;
            }
        }

        public Point C
        {
            get
            {
                return this.c;
            }
        }

        public Point D
        {
            get
            {
                return this.d;
            }
        }

        public LineSegment Ab
        {
            get
            {
                return new LineSegment(this.a, this.b);
            }
        }

        public LineSegment Bc
        {
            get
            {
                return new LineSegment(this.b, this.c);
            }
        }

        public LineSegment Cd
        {
            get
            {
                return new LineSegment(this.c, this.d);
            }
        }

        public LineSegment Da
        {
            get
            {
                return new LineSegment(this.d, this.a);
            }
        }

        public int Width
        {
            get
            {
                return this.b.X - this.a.X;
            }
        }

        public int Height
        {
            get
            {
                return this.d.Y - this.a.Y;
            }
        }

        public Point getCenter
        {
            get
            {
                return new Point(this.Ab.GetLength() / 2, this.Bc.GetLength() / 2);
            }
        }

        public static int getPerimeter(Rectangle rec)
        {
            return (rec.Ab.GetLength() * 2) + (rec.Bc.GetLength() * 2);
        }

        public static int getArea(Rectangle rec)
        {
            return rec.Ab.GetLength() * rec.Bc.GetLength();
        }

        public override string ToString()
        {
            return String.Format("Rectangle[({0},{1}), ({2},{3})]", this.a.X, this.a.Y, this.Height, this.Width);
        }

        public override bool Equals(object obj)
        {
            if ((obj as Rectangle).A.Equals(a) &&
                (obj as Rectangle).B.Equals(b) &&
                (obj as Rectangle).C.Equals(c) &&
                (obj as Rectangle).D.Equals(d))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Rectangle a, Rectangle b)
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

        public static bool operator !=(Rectangle a, Rectangle b)
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

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + a.GetHashCode();
                hash = hash * 23 + b.GetHashCode();
                hash = hash * 23 + c.GetHashCode();
                hash = hash * 23 + d.GetHashCode();
                return hash;
            }
        }
    }
}
