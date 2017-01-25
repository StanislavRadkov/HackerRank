using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/richie-rich
    public static class RichieRich
    {
        public static string GetBiggestPalindrome(string input, int k)
        {
            var number = input.ToCharArray();
            var n = 0;
            var changed = new bool[number.Length];

            for (var i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    if (number[i] > number[number.Length - i - 1])
                    {
                        changed[number.Length - i - 1] = true;
                        number[number.Length - i - 1] = number[i];
                    }
                    else
                    {
                        changed[i] = true;
                        number[i] = number[number.Length - i - 1];
                    }

                    n++;
                    if (n > k)
                    {
                        return null;
                    }
                }
            }

            if (n < k)
            {
                for (var i = 0; i < number.Length / 2 && n < k; i++)
                {                  
                    if (number[i] != '9')
                    {
                        var alreadyChanged = (changed[i] || changed[number.Length - i - 1]);
                        if (n + 2 <= k || (alreadyChanged && n < k))
                        {
                            number[i] = number[number.Length - i - 1] = '9';

                            if (alreadyChanged)
                            {
                                n++;
                            }
                            else
                            {
                                n += 2;
                            }             
                        }                       
                    }
                }
            }

            // Account for middle element
            if (number.Length % 2 != 0 && n < k)
            {
                number[number.Length/ 2] = '9';
            }

            return new String(number);
        }
    }
}
