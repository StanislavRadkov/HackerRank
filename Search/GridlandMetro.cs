using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/gridland-metro
    public class GridlandMetro
    {
        public static UInt64 Count(List<Tuple<UInt64, UInt64, UInt64>> tracks, UInt64 rows, UInt64 columns)
        {
            var dict = new Dictionary<UInt64, List<Tuple<UInt64, UInt64>>>();
            foreach (var track in tracks)
            {
                if (!dict.ContainsKey(track.Item1))
                {
                    dict.Add(track.Item1, new List<Tuple<ulong, ulong>>());
                }

                dict[track.Item1].Add(new Tuple<ulong, ulong>(track.Item2, track.Item3));
            }

            UInt64 count = 0;
            count += (rows - (UInt64)dict.Keys.Count) * columns;

            foreach (var row in dict)
            {
                row.Value.Sort((x, y) => x.Item1.CompareTo(y.Item1));

                UInt64 currentRowCount = 0;
                UInt64 start;
                UInt64 end;
                
                for (var i = 0; i < row.Value.Count; i++)
                {
                    start = row.Value[i].Item1;
                    end = row.Value[i].Item2;
                    while (i + 1 < row.Value.Count && row.Value[i + 1].Item1 <= end)
                    {
                        if (row.Value[i + 1].Item2 > end)
                        {
                            end = row.Value[i + 1].Item2;
                        }

                        i++;
                    }

                    currentRowCount += end - start + 1;
                }

                count += columns - currentRowCount;
            }

            return count;
        }
    }
}
