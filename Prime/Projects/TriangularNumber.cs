using System;

namespace Prime.Projects
{
    internal class TriangularNumber
    {
        public static long TriNumCalc(int val)
        {
            int numbers = 0;
            int inc = 1;

            for (int i = 1;; i += inc)
            {
                var jlim = Math.Sqrt(i);
                for (var j = 1; j <= jlim; j++) { 
                    if (i % j == 0)
                        numbers += 2;
                    if (j * j == val)
                        numbers--;
                }
                
                if (numbers > val) return i;
                numbers = 0;
                inc += 1;
            }
        }
    }
}
