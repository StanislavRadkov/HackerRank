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

            var currentlyHidden = new List<Tuple<int, int>>();
            var allHidden = ReadFile();
            
            for (var r = 0; r < board.Length; r++)
            {
                for (var c = 0; c < board[r].Length; c++)
                {
                    if (board[r][c] == dirt)
                    {
                        dirts.Add(new Tuple<int, int>(r, c));
                    }
                    else if(board[r][c] == hidden)
                    {
                        currentlyHidden.Add(new Tuple<int, int>(r, c));
                    }
                }
            }

            IEnumerable<Tuple<int, int>> remainingHidden;

            if (allHidden.Count() == 0)
            {
                remainingHidden = currentlyHidden;
            }
            else
            {
                remainingHidden = allHidden.Intersect(currentlyHidden);
            }
            WriteToFile(remainingHidden);
            
            var firstDirt = dirts.OrderBy(x => Math.Abs(row - x.Item1) + Math.Abs(column - x.Item2)).FirstOrDefault();

            if (firstDirt != null)
            {
                return GetMove(bot, firstDirt.Item1, firstDirt.Item2);
            }            
       
            var firstHidden = remainingHidden.OrderBy(x => Math.Abs(row - x.Item1) + Math.Abs(column - x.Item2)).FirstOrDefault();
            
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

        private static void WriteToFile(IEnumerable<Tuple<int, int>> hidden)
        {
            List<Tuple<int, int>> visited = new List<Tuple<int, int>>();

            string fileName = "myfile.txt";
            using (FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    foreach (var cell in hidden)
                    {
                        sw.WriteLine(String.Format($"{cell.Item1} {cell.Item2}"));
                    }
                }
            }
        }
    }
}