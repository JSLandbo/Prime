namespace Prime.Projects
{
    internal class PrimeFactor
    {
        internal static int FindLargest(int max, long v, int[] arr)
        {
            int largest = -1;
            for (var i = max; i >= 0; i--)
            {
                if (v % arr[i] != 0) continue;
                largest = arr[i];
                break;
            }
            return largest;
        }
    }
}
