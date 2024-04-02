using System.Threading.Tasks;

namespace Prime.Projects
{
    internal class Euler14
    {
        public static long Calc(int limit)
        {
            var val = 0;
            var lon = 0;
            var arr = new int[limit + 1];
            // Run program multi threaded
            Parallel.For(1, limit, i =>
            {
                // If index % 2 don't check, all longest chains has an odd number value
                if ((i & 1) == 0) return;
                // Check chain length for value
                arr[i] = CheckNum(i, limit, arr);
                // Check if new value has a longer chain
                if (arr[i] <= lon) return;
                // Set new longest chain
                val = i;
                lon = arr[i];
            });
            //Console.WriteLine(val + " has a chain length of " + lon);
            // Finished, return longest value
            return val;
        }

        public static int CheckNum(long index, int limit, int[] arr)
        {
            // Set n to num ( will need to set index to chain length
            var startNumber = index;
            // Start a new chain
            var chain = 0;
            // While num is bigger than 1 the length has yet to be found
            while (index > 1)
            {
                // If index is less t han limit it's within the 'arr' array
                if (index <= limit && arr[index] != 0)
                    // We have calculated chain length before, so simply use it again!
                    return chain += arr[index];
                // The actual chain logic
                if ((index & 1) == 0)
                    index = index / 2;
                else
                    index = index * 3 + 1;
                // Add the current link to the chain
                chain++;
            }
            // Set index to calculated chain length
            arr[startNumber] = chain;
            return chain;
        }
    }
}
