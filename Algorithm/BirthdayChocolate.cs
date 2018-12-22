using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class BirthdayChocolate
    {
        /*
         Lily has a chocolate bar that she wants to share it with Ron for his birthday. Each of the squares has an integer on it. She decides to share a contiguous segment of the bar selected such that the length of the segment matches Ron's birth month and the sum of the integers on the squares is equal to his birth day. You must determine how many ways she can divide the chocolate.
             */
        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {

            int total = 0, counter = 0;
            for (int i = 0; i < s.Count(); i++)
            {
                int limit = (i + m - 1) >= s.Count() ? s.Count() - 1 : (i + m - 1);
                for (int j = i; j <= limit; j++)
                {
                    total += s[j];
                }
                if (total == d)
                {
                    counter++;
                }
                total = 0;
            }

            return counter;
        }
    }
}
