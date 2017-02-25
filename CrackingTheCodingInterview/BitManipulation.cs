using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public static class BitManipulation
    {
        /* Youaregiven two 32-bit numbers, N andM, andtwobitpositions, i andj. Write a
         * method to insert M into Nsuch that M starts at bit j and ends at bit i. Youcan assume
         * that the bits j through i have enough space to fit all ofM. That is,ifM= 10011,
         * you can assumethat there are at least 5 bits between j and i. Youwould not, for
         * example, havej-3 and i=2, because Mcould not fully fit between bit 3 and bit2 */
        public static int UpdateBits(int n, int m, int i, int j)
        {
            for(int b = i, k = 0; b <= j; b++, k++)
            {
                n = (n & ~(1 << b)) | ((m & (1 << k)) << i);
            }

            return n;
        }
    }
}
