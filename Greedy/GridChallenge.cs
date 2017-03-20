using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/grid-challenge
    public class GridChallenge
    {
        private char[] _previousLine;

        public bool Line(string input)
        {
            var line = input.ToCharArray();
            Array.Sort(line);

            if (_previousLine != null)
            {
                for (var i = 0; i < _previousLine.Length; i++)
                {
                    if (_previousLine[i] > line[i])
                        return false;
                }
            }

            _previousLine = line;

            return true;
        }
    }
}
