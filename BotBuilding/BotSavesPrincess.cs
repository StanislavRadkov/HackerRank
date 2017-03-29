using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotBuilding
{
    // https://www.hackerrank.com/challenges/saveprincess
    public static class BotSavesPrincess
    {
        public static List<Tuple<string, int>> DisplayPathtoPrincess(Tuple<int, int> m, Tuple<int, int> p)
        {
            var moves = new List<Tuple<string, int>>();

            if (m.Item1 > p.Item1)
            {
                moves.Add(new Tuple<string, int>("UP", m.Item1 - p.Item1));
            }
            else if (m.Item1 < p.Item1)
            {
                moves.Add(new Tuple<string, int>("DOWN", p.Item1 - m.Item1));
            }

            if (m.Item2 > p.Item2)
            {
                moves.Add(new Tuple<string, int>("LEFT", m.Item2 - p.Item2));
            }
            else if (m.Item2 < p.Item2)
            {
                moves.Add(new Tuple<string, int>("RIGHT", p.Item2 - m.Item2));
            }

            return moves;
        }
    }
}
