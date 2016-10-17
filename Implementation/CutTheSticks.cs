using System.Collections.Generic;
using System.Linq;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/cut-the-sticks
    public static class CutTheSticks
    {
        public static List<int> Solve(List<int> sticks)
        {
            var lengths = new List<int>() {sticks.Count};
            var minValue = 0;
            var newMinValue = sticks.Min();

            while (sticks.Any())
            {
                minValue = newMinValue;
                newMinValue = int.MaxValue;

                for (var i = sticks.Count - 1; i >= 0; i--)
                {
                    sticks[i] -= minValue;
                    if (sticks[i] <= 0)
                    {
                        sticks.RemoveAt(i);
                    }
                    else
                    {
                        if (sticks[i] < newMinValue)
                        {
                            newMinValue = sticks[i];
                        }
                    }
                }

                if (sticks.Count > 0)
                {
                    lengths.Add(sticks.Count);
                }
            }

            return lengths;
        }
    }
}
