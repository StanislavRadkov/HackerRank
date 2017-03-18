using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/weighted-uniform-string
    public class WeightedUniformStrings
    {
        private HashSet<int> _values;
        private string _a;
         
        public WeightedUniformStrings(string a)
        {
            _values = new HashSet<int>();

            _a = a;
        }

        public void Init()
        {
            _values.Add(_a[0] - 96);
            var currentSubstringValue = (int)(_a[0] - 96);

            for (var i = 1; i < _a.Length; i++)
            {

                if (_a[i] != _a[i - 1])
                {
                    _values.Add(currentSubstringValue);
                    currentSubstringValue = _a[i] - 96;
                }
                else
                {
                    _values.Add(currentSubstringValue);
                    currentSubstringValue += (_a[i] - 96);
                }

                _values.Add(_a[i] - 96);
            }

            _values.Add(currentSubstringValue);
        }

        public bool In(int value)
        {
            return _values.Contains(value);
        }
    }
}
