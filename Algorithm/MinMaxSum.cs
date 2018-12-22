using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MinMaxSum
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            long min = arr[0], max = 0, sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine((sum - max) + " " + (sum - min));
        }

    }
}
