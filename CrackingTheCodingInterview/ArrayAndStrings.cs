using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public static class ArrayAndStrings
    {
        /* Implement an algorithm to determine if a string has all unique characters. What if
         * you cannot use additional data structures? */
        public static bool AllUniqueCharactersASCII(string a)
        {
            var chars = new bool[256];

            for (var i = 0; i < a.Length; i++)
            {
                if (chars[a[i]])
                {
                    return false;
                }

                chars[a[i]] = true;
            }

            return true;
        }
        
        public static bool AllUniqueCharactersUnicode(string a)
        {
            var hashSet = new HashSet<char>();

            for (var i = 0; i < a.Length; i++)
            {
                if (hashSet.Contains(a[i]))
                {
                    return false;
                }

                hashSet.Add(a[i]);
            }

            return true;
        }

        /* Implement a function void reversefchar* str) in Cor C++ which reverses a null-terminated 
         * string. */
        public static string ReverseString(string a)
        {
            var input = a.ToCharArray();
            char temp;

            for (var i = 0; i < input.Length/2; i++)
            {
                temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }

            return String.Join(String.Empty, input);
        }

        /* Given two strings, write a method to decide if one is a permutation of the other. */
        public static bool IsPermutation(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var chars1 = a.ToCharArray();
            var chars2 = b.ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            for (var i = 0; i < chars1.Length; i++)
            {
                if (chars1[i] != chars2[i])
                {
                    return false;
                }
            }

            return true;
        }

        /*Write a method to replace all spaces in a string with '%20'. You may assume that the 
         * string has sufficient space at the end of the string to hold the additional characters, 
         * and that you are given the "true" length of the string. (Note: if implementing in Java, 
         * please use a character array so that you can perform this operation in place.) */
        public static string ReplaceSpaces(string a)
        {
            return a.Trim().Replace(" ", "%20");
        }

        /* Implement a method to perform basic string compression using the counts of 
         * repeated characters. For example, the string aabcccccaaa would become 
         * a2blc5a3. If the "compressed" string would not become smaller than the original 
         * string, your method should return the original string */
        public static string CompressString(string a)
        {
            var sb = new StringBuilder(a.Length);

            for (var i = 0; i < a.Length;)
            {
                var c = a[i];
                var s = 1;
                while (++i < a.Length && a[i] == c)
                {
                    s++;
                }

                sb.Append(String.Format("{0}{1}", c, s));
            }

            return sb.Length < a.Length ? sb.ToString() : a;
        }

        /* Given an image represented by an NxN matrix, where each pixel in the image is 4 
         * bytes, write a method to rotate the image by 90 degrees. Can you do this in place? */
        public static void RotateMatrix(int[][] matrix)
        {
            var n = matrix.Length;
            int temp;

            for (var row = 0; row < n/2; row++)
            {
                for (var column = 0; column < n/2; column++)
                {
                    temp = matrix[row][column];

                    matrix[row][column] = matrix[n - column - 1][row];

                    matrix[n - column - 1][row] = matrix[n - row - 1][n - column - 1];

                    matrix[n - row - 1][n - column - 1] = matrix[column][n - row - 1];

                    matrix[column][n - row - 1] = temp;
                }
            }
        }

        /* Write an algorithm such that if an element in an MxN matrix is 0, its entire row and 
         * column are set to 0. */
        public static void SetRowAndColumnToZero(int[][] matrix)
        {
            var rows = new bool[matrix.Length];
            var columns = new bool[matrix[0].Length];

            for (var row = 0; row < rows.Length; row++)
            {
                for (var column = 0; column < columns.Length; column++)
                {
                    if (matrix[row][column] == 0)
                    {
                        rows[row] = true;
                        columns[column] = true;
                    }
                }
            }

            for (var row = 0; row < rows.Length; row++)
            {
                for (var column = 0; column < columns.Length; column++)
                {
                    if (rows[row] || columns[column])
                    {
                        matrix[row][column] = 0;
                    }
                }
            }
        }

        /* Assume you have a method isSubstring which checks if one word is a substring 
         * of another. Given two strings, si and s2, write code to check Ifs2 is a rotation of si 
         * using only onecalltoisSubstring (e.g., "waterbottLe" is a rotation of "erbottLewat"). */
        public static bool IsRotation(string a, string b)
        {
            var aa = a + a;

            return aa.IndexOf(b) >= 0;
        } 
    }
}
