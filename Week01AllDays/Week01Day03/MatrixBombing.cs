using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class MatrixBombing
    {
        public static int MatrixBomb(int[,] matrix)
        {
            int result = 0;

            int tempDamage = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int bomb = matrix[i, j];
                    tempDamage = 0;

                    for (int row = i - 1; row <= i + 1; row++)
                    {
                        for (int col = j - 1; col <= j + 1; col++)
                        {
                            if (row < 0)
                            {
                                continue;
                            }
                            else if (row >= matrix.GetLength(0))
                            {
                                continue;
                            }
                            else if (col < 0)
                            {
                                continue;
                            }
                            else if (col >= matrix.GetLength(1))
                            {
                                continue;
                            }
                            else if (row == i && col == j)
                            {
                                continue;
                            }
                            else
                            {
                                if (bomb > matrix[row, col])
                                {
                                    tempDamage += matrix[row, col];
                                }
                                else
                                {
                                    tempDamage += bomb;
                                }
                            }
                        }
                    }

                    if (tempDamage > result)
                    {
                        result = tempDamage;
                    }

                }
            }

            return result;
        }
    }
}
