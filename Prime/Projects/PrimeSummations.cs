namespace Prime.Projects
{
    class PrimeSummations
    {
        public static int Calc(int amount, int[] primes)
        {
            int target = 0;
            while (true)
            {
                int[] cache = new int[target + 1];
                cache[0] = 1;
                for (int i = 0; i < primes.Length; i++) { 
                    for (var j = primes[i]; j <= target; j++)
                        cache[j] += cache[j - primes[i]];
                }
                if (cache[target] > amount) break;
                target++;
            }
            return target;
        }
    }
}
