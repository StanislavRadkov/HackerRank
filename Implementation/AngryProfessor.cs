using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/angry-professor
    public static class AngryProfessor
    {
        public static bool IsClassCanceled(int limit, int[] times)
        {
            return times.Count(t => t <= 0) < limit;
        }
    }
}
