using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class AppleAndOrange
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {

            int mCount = 0, nCount = 0;

            if (apples.Length == oranges.Length)//if array lengths are equal
            {
                for (int i = 0; i < apples.Length; i++)//use only one loop
                {
                    mCount = ((a + apples[i]) >= s && (a + apples[i]) <= t) ? (mCount += 1) : mCount;
                    nCount = ((b + oranges[i]) >= s && (b + oranges[i]) <= t) ? (nCount += 1) : nCount;
                }
            }
            else//if array lengths are not equal(You need use two loop)
            {
                for (int i = 0; i < apples.Length; i++)
                {
                    mCount = ((a + apples[i]) >= s && (a + apples[i]) <= t) ? (mCount += 1) : mCount;
                }

                for (int i = 0; i < oranges.Length; i++)
                {
                    nCount = ((b + oranges[i]) >= s && (b + oranges[i]) <= t) ? (nCount += 1) : nCount;
                }
            }

            Console.Write(mCount + "\n" + nCount);
        }
    }
}
