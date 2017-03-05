using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/sherlock-and-array
    public class SherlockAndArray
    {
        public static bool SumsExist(int[] input)
        {
            if (input.Length == 1)
            {
                return true;
            }
            if (input.Length < 3)
            {
                return false;
            }

            var rightSum = input.Sum() - input[0];
            var leftSum = 0;

            for (var i = 1; i < input.Length - 1; i++)
            {
                leftSum += input[i - 1];
                rightSum -= input[i];

                if (leftSum == rightSum)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
