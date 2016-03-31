using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2
{
    class RandomNumbers
    {
        public static void GenerateRandomMatrix(int rows, int cols)
        {
            double[,] array = new double[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.NextDouble() * (1000.0 - 0.0) + 0.0; 
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,8:F2}", array[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
