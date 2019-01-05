using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class CountingValleys
    {
        public int countingValleys(int n, string s)
        {

            int Ucounter = 0, Dcounter = 0, Sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U')
                    Ucounter++;
                else
                    Dcounter++;

                if (Ucounter == Dcounter && s[i]== 'U')
                    Sum++;
            }

            return Sum;

        }
    }
}
