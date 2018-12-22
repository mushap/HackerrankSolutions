using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class TimeConversion
    {       
        //Given a time in -hour AM/PM format, convert it to military (24-hour) time.
        static string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }
    }
}
