using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class BetweenTwoSets
    {
        /*You will be given two arrays of integers and asked to determine all integers that satisfy the following two conditions:
        The elements of the first array are all factors of the integer being considered
        The integer being considered is a factor of all elements of the second array
        These numbers are referred to as being between the two arrays. You must determine how many such numbers exist.*/

        static List<int> getBetween(int[] a, int bFirst)
        {
            int counter = 0, arrayLength = a.Length;
            var c = new List<int>();

            for (int i = a[arrayLength - 1]; i <= bFirst; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (i % a[j] == 0)
                    {
                        counter++;
                    }
                }
                if (counter == arrayLength)
                {
                    c.Add(i);
                    Console.WriteLine("i={0}", i);
                }
                counter = 0;
            }

            return c;
        }

    }
}
