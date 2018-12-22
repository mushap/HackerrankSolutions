using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Staircase
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            string wrt = "";
            for (int i = 0; i < n; i++)
            {
                Console.Write(wrt.PadLeft(n - (i + 1)));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
