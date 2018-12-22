using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PlusMinus
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {

            double positive = 0, negative = 0, zero = 0, len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] > 0)
                    positive++;
                else if (arr[i] < 0)
                    negative++;
                else
                    zero++;
            }

            Console.WriteLine(string.Format("{0:F6}\n{1:F6}\n{2:F6}", positive / len, negative / len, zero / len));

        }
    }
}
