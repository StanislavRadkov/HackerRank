using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/icecream-parlor
    public class IcecreamParlor
    {
        public static Tuple<int, int> Get(int[] data, int sum)
        {
            var input = data
                .Select((value, index) => new KeyValuePair<int, int>(index + 1, value))
                .OrderBy(x => x.Value)
                .ToArray();

            var i = 0;
            var j = input.Length - 1;

            while (i < j)
            {
                var currentSum = input[i].Value + input[j].Value;

                if (currentSum == sum)
                {
                    return new Tuple<int, int>(Math.Min(input[i].Key, input[j].Key), Math.Max(input[i].Key, input[j].Key));
                }

                if (currentSum > sum)
                {
                    j--;
                }
                else if (currentSum < sum)
                {
                    i++;
                }
            }

            return null;
        }
    }
}
