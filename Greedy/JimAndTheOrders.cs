using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/jim-and-the-orders
    public static class JimAndTheOrders
    {
        public static IEnumerable<int> Orders(KeyValuePair<int, int>[] orders)
        {
            return orders
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => x.Key);
        }
    }
}
