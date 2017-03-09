using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/count-luck
    public class CountLuck
    {
        private const char tree = 'X';
        private const char empty = '.';
        private const char Hermione = 'M';
        private const char portkey = '*';

        public static bool Count(char[][] wood, int k)
        {
            var visited = new bool[wood.Length][];
            for (int i = 0; i < wood.Length; i++)
            {
                visited[i] = new bool[wood[i].Length];
            }

            int count = 0;

            for (var row = 0; row < wood.Length; row++)
            {
                for (var column = 0; column < wood[row].Length; column++)
                {
                    if (wood[row][column] == Hermione)
                    {
                        CountPath(wood, visited, row, column, ref count);

                        return count == k;
                    }
                }
            }

            return false;
        }

        private static bool CountPath(char[][] wood, bool[][] visited, int row, int column, ref int count)
        {
            //for (var i = 0; i < wood.Length; i++)
            //{
            //    for (var j = 0; j < wood[i].Length; j++)
            //    {
            //        var prefix = (i == row && j == column) ? "[" : " ";
            //        var postfix = (i == row && j == column) ? "]" : " ";
            //        Trace.Write($"{prefix}{wood[i][j]}{postfix}");
            //    }

            //    Trace.WriteLine(String.Empty);
            //}

            //Trace.WriteLine(String.Empty);

            Func<int, int, bool> canMove = (r, c) =>
                (r >= 0 && r < wood.Length)
                && (c >= 0 && c < wood[r].Length)
                && (wood[r][c] != tree) && visited[r][c] == false;

            visited[row][column] = true;

            if (wood[row][column] == portkey)
            {
                return true;
            }

            var pathFoud = false;
            var possibleMoves = 0;

            if (canMove(row + 1, column))
            {
                possibleMoves++;
                pathFoud = pathFoud || CountPath(wood, visited, row + 1, column, ref count);
            }

            if (canMove(row - 1, column))
            {
                possibleMoves++;
                pathFoud = pathFoud || CountPath(wood, visited, row - 1, column, ref count);
            }

            if (canMove(row, column + 1))
            {
                possibleMoves++;
                pathFoud = pathFoud || CountPath(wood, visited, row, column + 1, ref count);
            }

            if (canMove(row, column - 1))
            {
                possibleMoves++;
                pathFoud = pathFoud || CountPath(wood, visited, row, column - 1, ref count);
            }

            if (possibleMoves > 1 && pathFoud)
            {
                count++;
            }

            return pathFoud;
        }
    }
}
