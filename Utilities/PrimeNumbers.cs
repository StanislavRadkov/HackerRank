using System.Collections;
using System.Collections.Generic;

namespace Utilities
{
    public class PrimeNumbers : IEnumerator<long>, IEnumerable<long>
    {
        private long _primeCounter = 0;
        private long _number = 2;
        private long _currentPrime = 2;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            do
            {
                _number++;
            } while (!Utils.IsPrime(_number));

            _currentPrime = _number;
            _primeCounter++;

            return true;
        }

        public void Reset()
        {
            _primeCounter = 0;
            _number = 1;
        }

        public long Number
        {
            get { return _primeCounter; }
        }

        public long Current
        {
            get { return _currentPrime; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public IEnumerator<long> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
