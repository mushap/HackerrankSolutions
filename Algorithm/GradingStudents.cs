using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class GradingStudents
    {
        static int[] gradingStudents(int[] grades)
        {
            int[] returnGrades = new int[grades.Length];
            int mod = 5;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38 || grades[i] % mod < 3)
                    returnGrades[i] = grades[i];
                else
                    returnGrades[i] = grades[i] + (mod - (grades[i] % mod));
            }

            return returnGrades;
        }
    }
}
