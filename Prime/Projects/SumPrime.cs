namespace Prime.Projects
{
    internal class SumPrime
    {
        public static long SumPrimeFind(long max, int[] arr)
        {
            long sum = 0;
            var ma = arr.Length - 1;
            for (var i = 0; i <= ma; i++)
            {
                if (arr[i] >= max) break;
                sum += arr[i];
            }
            return sum;
        }
    }
}
