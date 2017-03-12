using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    // https://www.hackerrank.com/challenges/journey-to-the-moon/
    public class JourneyToTheMoon
    {
        private List<HashSet<int>> _countries;
        private int _n;

        public JourneyToTheMoon(int n)
        {
            _n = n;
            _countries = new List<HashSet<int>>();
        }

        public void Add(int a, int b)
        {
            var found = false;
            var foundIndex = 0;

            for (var i = 0; i < _countries.Count; i++)
            {
                var country = _countries[i];
                if (country.Contains(a) || country.Contains(b))
                {
                    country.Add(a);
                    country.Add(b);

                    if (found)
                    {
                        _countries[i].UnionWith(_countries[foundIndex]);
                        _countries.RemoveAt(foundIndex);
                        break;
                    }
                    else
                    {
                        found = true;
                        foundIndex = i;
                    }
                }
            }

            if (!found)
            {
                var hash = new HashSet<int> {a, b};
                _countries.Add(hash);
            }
        }

        public long GetPossibleCombinations()
        {
            checked
            {
                long n = _n;
                long pairs = 0;
                long countriesCount = _countries.Count + (_n - _countries.Select(s => s.Count).Sum());

                for (var j = 0; j < countriesCount; j++)
                {
                    if (j < _countries.Count)
                    {
                        pairs += (n -= _countries[j].Count)*_countries[j].Count;
                    }
                    else
                    {
                        pairs += (n -= 1)*1;
                    }
                }

                return pairs;
            }
        }
    }
}
