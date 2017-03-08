using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/connected-cell-in-a-grid
    public class ConnectedCellsInAGrid
    {
        private const int _visisted = -1;

        public static int MaxCount(int[][] m)
        {
            int max = 0;

            for (var row = 0; row < m.Length; row++)
            {
                for (var column = 0; column < m[row].Length; column++)
                {
                    max = Math.Max(max, Count(m, row, column));
                }
            }            

            return max;
        }

        private static int Count(int[][] m, int row, int column)
        {
            if (!(row < m.Length && row >= 0))
            {
                return 0;
            }

            if (!(column < m[row].Length && column >= 0))
            {
                return 0;
            }

            var count = 0;

            if (m[row][column] == _visisted || m[row][column] == 0)
            {
                return 0;
            }
            else if (m[row][column] == 1)
            {
                count++;
                m[row][column] = _visisted;
            }

            count += Count(m, row - 1, column - 1);
            count += Count(m, row - 1, column);
            count += Count(m, row - 1, column + 1);
                              
            count += Count(m, row, column - 1);
            count += Count(m, row, column + 1);
                              
            count += Count(m, row + 1, column - 1);
            count += Count(m, row + 1, column);
            count += Count(m, row + 1, column + 1);

            return count;
        }
    }
}
