using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MigratoryBirds
    {
        // Complete the migratoryBirds function below.
        public int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            if (arr.Any())
            {

                for (int i = 0; i < arr.Count; i++)
                {
                    if (dictionary.ContainsKey(arr[i]))
                    {
                        dictionary[arr[i]] = dictionary[arr[i]] + 1;
                    }
                    else
                    {
                        dictionary.Add(arr[i], 1);
                    }
                }

                var getKeyHasMaxValue = dictionary.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key).Where(x => x.Value == dictionary.Values.Max()).Select(s => s.Key).FirstOrDefault();


                return getKeyHasMaxValue;

            }
            return 0;
        }
        public int migratoryBirds2(List<int> arr)
        {
            if (arr.Any())
            {

                return arr.GroupBy(g => g).Select(s => new { Key = s.Key, Count = s.Count() }).OrderByDescending(o => o.Count).First().Key;
            }

            return 0;
        }

    }
}
