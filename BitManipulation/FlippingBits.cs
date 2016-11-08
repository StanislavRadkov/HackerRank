namespace BitManipulation
{
    // https://www.hackerrank.com/challenges/flipping-bits
    public static class FlippingBits
    {
        public static uint[] Solve(uint[] input)
        {
            var numbers = input.Clone() as uint[];
            for (var n = 0; n < numbers.Length; n++)
            {
                numbers[n] = ~numbers[n];
            }

            return numbers;
        }
    }
}
