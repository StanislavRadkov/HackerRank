using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotBuilding
{
    // https://www.hackerrank.com/challenges/botclean
    public static class BotClean
    {
        public static string NextMove(int row, int column, string[] board)
        {
            var bot = new Tuple<int, int>(row, column);
            const char dirt = 'd';

            if (board[row][column] == dirt)
            {
                return "CLEAN";
            }

            int i = 0;

            Func<int> up = () => row - i >= 0 ? row - i : 0;
            Func<int> down = () => row + i < board.Length ?  row + i : board.Length - 1;
            Func<int> left = () => column - i > 0 ? column - i : 0;
            Func<int> right = () => column + i < board[row].Length ? column + i : board[row].Length -1;
            Func<int, int, bool> isDirty = (r, c) => board[r][c] == dirt;

            for (i = 1; i < board.Length; i++)
            {
                if (isDirty(up(), column))
                    return GetMove(bot, up(), column);

                if (isDirty(down(), column))
                    return GetMove(bot, down(), column);

                if (isDirty(row, left()))
                    return GetMove(bot, row, left());

                if (isDirty(row, right()))
                    return GetMove(bot, row, right());
                
                if (isDirty(up(), left()))
                    return GetMove(bot, up(), left());

                if (isDirty(up(), right()))
                    return GetMove(bot, up(), right());

                if (isDirty(down(), left()))
                    return GetMove(bot, down(), left());

                if (isDirty(down(), right()))
                    return GetMove(bot, down(), right());
            }

            throw new Exception();
        }

        private static string GetMove(Tuple<int, int> m, int row, int column)
        {
            if (m.Item1 > row)
            {
                return "UP";
            }
            else if (m.Item1 < row)
            {
                return "DOWN";
            }

            if (m.Item2 > column)
            {
                return "LEFT";
            }
            else if (m.Item2 < column)
            {
                return "RIGHT";
            }

            throw new Exception();
        }
    }
}
