using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
   public class SockMerchant
    {
      public int sockMerchant(int n, int[] ar)
        {

            return ar.GroupBy(g => g).Where(w => w.Count() > 1).Select(s => new { Fin = (s.Count() - (s.Count() % 2)) / 2 }).Sum(a => a.Fin);

        }
    }
}
