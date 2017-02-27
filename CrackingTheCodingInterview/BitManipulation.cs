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

        /* Given a positive integer, print the next smallest and the next largest number that 
         * have the same number of 7bits in their binary representation. */
        public static Tuple<uint, uint> GetNextNumbersWithSameNumberBruteForce(uint number)
        {
            checked
            {
                var bits = CountBits(number);

                var previous = number;
                while (CountBits(--previous) != bits) ;

                var next = number;
                while (CountBits(++next) != bits) ;

                return new Tuple<uint, uint>(previous, next);
            }
        }

        public static byte CountBits(uint number)
        {
            byte n = 0;

            for (var i = 0; i < 32; i++)
            {
                if ((number & (1 << i)) != 0)
                {
                    n++;
                }
            }

            return n;
        }

        // http://algorithmsandme.in/2014/04/next-smallest-number-with-same-number-of-bits-set/
        public static Tuple<uint, uint> GetNextNumbersWithSameNumber(uint x)
        {
            checked
            {
                var rightmost = x & ~(x - 1);
                var swapped = x + rightmost;
                var xor = x ^ swapped;
                var adjusted = (xor >> 2)/rightmost;
                var next = swapped | adjusted;

                var t = x + 1;
                var u = t ^ x;
                var v = t & x;
                uint previous = (uint)(v - (v & -v) / (u + 1));

                return new Tuple<uint, uint>(previous, next);
            }
        }

        /* Write a function to determine the number of bits required to convert integer A to integer B */
        public static int CountBitsToConvert(uint a, uint b)
        {
            var count = 0;

            for (var c = a ^ b; c != 0; c = c & (c - 1))
            {
                count++;
            }

            return count;
        }

        /* Write a program to swap odd and even bits in an integer with as few instructions as 
         * possible (e.g., bit 0 and bit! are swapped, bit 2 and bit 3 are swapped, and soon) */
        public static uint SwapBits(uint x)
        {
            // 0xAAAAAAAA -> 10101010101010101010101010101010
            // 0x55555555 -> 1010101010101010101010101010101

            return (((x & 0xAAAAAAAA) >> 1) | ((x & 0x55555555) << 1) );
        }
    }
}
