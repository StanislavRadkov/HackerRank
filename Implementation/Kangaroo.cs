namespace Implementation
{
    public static class Kangaroo
    {
        public static bool Solve(int x1, int v1, int x2, int v2)
        {
            if (v1 <= v2)
            {
                return false;
            }
            else
            {
                return (x2 - x1) % (v1 - v2) == 0;
            }
        }
    }
}
