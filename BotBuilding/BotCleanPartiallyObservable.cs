using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotBuilding
{
    // https://www.hackerrank.com/challenges/botcleanv2
    public class BotCleanPartiallyObservable
    {
        private const char dirt = 'd';
        private const char hidden = 'o';

        public static string NextMove(int row, int column, string[] board)
        {
            if (board[row][column] == dirt)
            {
                return "CLEAN";
            }

            var bot = new Tuple<int, int>(row, column);
            var dirts = new List<Tuple<int, int>>();
            var all = new List<Tuple<int, int>>();

            WriteToFile(bot);
            var visited = ReadFile();

            for (var r = 0; r < board.Length; r++)
            {
                for (var c = 0; c < board[r].Length; c++)
                {
                    if (board[r][c] == dirt)
                    {
                        dirts.Add(new Tuple<int, int>(r, c));
                    }
                    else
                    {
                        all.Add(new Tuple<int, int>(r, c));
                    }
                }
            }

            var firstDirt = dirts.OrderBy(x => Math.Abs(row - x.Item1) + Math.Abs(column - x.Item2)).FirstOrDefault();

            if (firstDirt != null)
            {
                return GetMove(bot, firstDirt.Item1, firstDirt.Item2);
            }

            var firstHidden = all.Except(visited).OrderBy(x => Math.Abs(row - x.Item1) + Math.Abs(column - x.Item2)).FirstOrDefault();
            
            if (firstHidden != null)
            {
                return GetMove(bot, firstHidden.Item1, firstHidden.Item2);
            }

            throw new Exception();
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

        private static List<Tuple<int, int>> ReadFile()
        {
            string fileName = "myfile.txt";
            List<Tuple<int, int>> visited = new List<Tuple<int, int>>();


            if (!File.Exists(fileName))
            {
                return visited;
            }

            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        var tokens = line.Split();
                        visited.Add(new Tuple<int, int>(int.Parse(tokens[0]), int.Parse(tokens[1])));
                    }                 
                }
            }

            return visited;
        }

        private static void WriteToFile(Tuple<int, int> cell)
        {
            List<Tuple<int, int>> visited = new List<Tuple<int, int>>();

            string fileName = "myfile.txt";
            using (FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(file))
                {                    
                    sw.WriteLine(String.Format($"{cell.Item1} {cell.Item2}"));
                }
            }
        }
    }
}