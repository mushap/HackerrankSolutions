using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
  public class CompareTheTriplets
    {
        // Complete the compareTriplets function below.
      public static List<int> compareTriplets(List<int> a, List<int> b)
        {

            int first = 0, second = 0;

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                {
                    first++;
                }
                else if (b[i] > a[i])
                {
                    second++;
                }
            }

            List<int> ab = new List<int>();
            ab.Add(first);
            ab.Add(second);

            return ab;
        }
    }
}
