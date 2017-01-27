using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public static class ArrayAndStrings
    {
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

        public static string ReplaceSpaces(string a)
        {
            return a.Trim().Replace(" ", "%20");
        }

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
    }
}
