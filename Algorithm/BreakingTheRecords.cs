using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class BreakingTheRecords
    {
           /*Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. She tabulates the number of times she breaks her season record for most points and least points in a game. Points scored in the first game establish her record for the season, and she begins counting from there.*/

        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {

            int max = scores[0], min = scores[0], minCounter = 0, maxCounter = 0;
            int[] counterArray = new int[2];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                    minCounter++;
                }
                if (scores[i] > max)
                {
                    max = scores[i];
                    maxCounter++;
                }
            }

            counterArray[0] = maxCounter;
            counterArray[1] = minCounter;

            return counterArray;
        }
    }
}
