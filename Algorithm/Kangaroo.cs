using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Kangaroo
    {
        /* You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).
        The first kangaroo starts at location  and moves at a rate of  meters per jump.
        The second kangaroo starts at location  and moves at a rate of  meters per jump.
        You have to figure out a way to get both kangaroos at the same location at the same time as part of the show. If it is possible, return YES, otherwise return NO. */

        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {

            if (((x1 > x2 && v1 > v2) || (x1 < x2 && v1 < v2)) || ((x1 == x2 && v1 != v2) || (x1 != x2 && v1 == v2)) || (v1 == 0 || v2 == 0))
                return "NO";
            else if (x1 == x2 && v1 == v2)
                return "YES";
            else
            {
                int t = 0;
                if (x1 > x2)
                    t = (x1 - x2) / (v2 - v1);
                else
                    t = (x2 - x1) / (v1 - v2);

                if ((x1 + t * v1) == (x2 + t * v2))
                    return "YES";
                else
                    return "NO";
            }
        }
    }
}
