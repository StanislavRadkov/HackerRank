using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotBuilding
{
    // https://www.hackerrank.com/challenges/botcleanr
    public class BotCleanStochastic
    {
        private const char dirt = 'd';

        public static string NextMove(int row, int column, string[] board)
        {
            if (board[row][column] == dirt)
            {
                return "CLEAN";
            }

            var bot = new Tuple<int, int>(row, column);
            var dirts = new List<Tuple<int, int>>();

            for (var r = 0; r < board.Length; r++)
            {
                for (var c = 0; c < board[r].Length; c++)
                {
                    if (board[r][c] == dirt)
                    {
                        dirts.Add(new Tuple<int, int>(r, c));
                    }
                }
            }

            var first = dirts.OrderBy(x => Math.Abs(row - x.Item1) + Math.Abs(column - x.Item2)).First();

            return GetMove(bot, first.Item1, first.Item2);
        }

        private static string GetMove(Tuple<int, int> bot, int row, int column)
        {
            if (bot.Item1 > row)
            {
                return "UP";
            }
            else if (bot.Item1 < row)
            {
                return "DOWN";
            }

            if (bot.Item2 > column)
            {
                return "LEFT";
            }
            else if (bot.Item2 < column)
            {
                return "RIGHT";
            }

            throw new Exception();
        }
    }
}
