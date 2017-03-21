using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/greedy-florist
    public static class GreedyFlorist
    {
        public static int GetPrice(int[] prices, int flowers, int people)
        {
            var price = 0;
            Array.Sort(prices, (x1, x2) => x2.CompareTo(x1));

            var p = 0;
            var remainingPeopleForIteration = people;

            for (var i = 0; i < prices.Length && flowers > 0; i = (i+1) % prices.Length)
            {
                price += (p + 1) * prices[i];
                flowers--;
                remainingPeopleForIteration--;

                if (remainingPeopleForIteration == 0)
                {
                    p++;
                    remainingPeopleForIteration = people;
                }
            }

            return price;
        }
    }
}
