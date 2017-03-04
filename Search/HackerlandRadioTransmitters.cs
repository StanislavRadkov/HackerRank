using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/hackerland-radio-transmitters
    public class HackerlandRadioTransmitters
    {
        public static int Count(int[] data, int k)
        {
            Array.Sort(data);

            var count = 0;
            var pos = 0;

            while (pos < data.Length)
            {
                count++;

                var towerPosition = pos;
                while (towerPosition < data.Length - 1 && (data[towerPosition + 1] - data[pos]) <= k)
                {
                    towerPosition++;
                }

                var coverage = towerPosition;
                while (coverage < data.Length - 1 && (data[coverage + 1] - data[towerPosition]) <= k)
                {
                    coverage++;
                }

                pos = coverage + 1;
            }

            return count;
        }
    }
}
