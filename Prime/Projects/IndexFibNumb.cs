using System;

namespace Prime.Projects
{
    internal class IndexFibNumb
    {
        public static int FindFibs(int i)
        {
            if (i == 1)
                return 1;
            var t = (i * 4 - 4);
            for (var n = t;; n++)
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (Math.Ceiling((n * Math.Log10(1.6180339887498948)) - ((Math.Log10(5)) / 2)) == i) {
                    //Console.WriteLine(i + " decimal fibonacci found at index: " + n);
                    return n;
                }
        }
    }
}
