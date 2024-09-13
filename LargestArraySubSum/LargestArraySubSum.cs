namespace XUnitLib
{
    public static class LargestArraySubSum
    {
        public static int Compute(int[] a)
        {
            int current = 0, longest = 0;

            for (var i = 0; i < a.Length; ++i)
            {
                current += a[i];

                if (current < 0)
                    current = 0;
                else if (current > longest)
                    longest = current;
            }

            return longest;
        }
    }
}