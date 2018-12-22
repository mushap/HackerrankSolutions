using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class DiagonalDifference
    {
        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
        {

            int lengthOfArray = arr.GetLength(0), sumFirst = 0, sumSecond = 0;

            for (int i = 0; i < lengthOfArray; i++)
            {
                for (int j = 0; j < lengthOfArray; j++)
                {
                    if (i == j)
                    {
                        sumFirst += arr[i][j];
                    }
                    if (lengthOfArray - (i + j) == 1)
                    {
                        sumSecond += arr[i][j];
                    }
                }
            }

            return Math.Abs(sumFirst - sumSecond);
        }
    }
}
