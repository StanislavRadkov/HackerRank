using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/jumping-on-the-clouds
    public static class JumpingOnTheClouds
    {
        public static int Solve(bool[] clouds)
        {
            var steps = 0;

            for (var i = 0; i < clouds.Length - 1; ) 
            {
                if (i + 2 < clouds.Length && clouds[i + 2] == false)
                {
                    steps++;
                    i += 2;
                }
                else if (i + 1 < clouds.Length && clouds[i + 1] == false)
                {
                    steps++;
                    i += 1;
                }
            }

            return steps;
        }
    }
}
