using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/missing-numbers
    public class MissingNumbers
    {
        public static IEnumerable<int> Get(int[] a, int[] b)
        {
            var groups = from s in b
                group s by s into g
                select new {Stuff = g.Key, Count = g.Count()};

            var dictionary = groups.ToDictionary(g => g.Stuff, g => g.Count);

            foreach (var item in a)
            {
                dictionary[item]--;
            }

            return dictionary.Keys.OrderBy(x => x).Where(item => dictionary[item] > 0);
        }
    }
}
