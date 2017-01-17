using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public static class ArraysLeftRotation
    {
        public static StringBuilder RotateLeft(int[] arr, int[] tokens)
        {
            var stringBuilder = new StringBuilder(arr.Length * 5);

            for (var rot = tokens[1]; rot < tokens[1] + arr.Length; rot++)
            {
                stringBuilder.Append(arr[rot % arr.Length]);
                stringBuilder.Append(" ");
            }

            stringBuilder.Length--;

            return stringBuilder;
        }
    }
}
