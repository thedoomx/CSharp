using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2
{
    class PolygonTasks
    {
        public static float CalcCircumference(PointF[] points)
        {
            float result = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                result += (float)Math.Sqrt((float)Math.Pow(points[i].X - points[i + 1].X, 2) + (float)Math.Pow(points[i].Y - points[i + 1].Y, 2));
            }
            result += (float)Math.Sqrt((float)Math.Pow(points[points.Length - 1].X - points[0].X, 2) + 
              (float)Math.Pow(points[points.Length - 1].Y - points[0].Y, 2));

            return result;
        }

        public static float CalcArea(PointF[] points)
        {
            float sumOfX = 0;
            float sumOfY = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sumOfX += points[i].X * points[i + 1].Y;
            }
            sumOfX += points[points.Length - 1].X * points[0].Y;

            for (int i = 0; i < points.Length - 1; i++)
            {
                sumOfY += points[i].Y * points[i + 1].X;
            }
            sumOfY += points[points.Length - 1].Y * points[0].X;

            return (sumOfX - sumOfY) / 2;
        }
    }
}
