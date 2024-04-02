using System;

namespace Prime.Projects
{
    class MultiplesOfThreeAndFive
    {
        public static long Calc()
        {
            var sum = 0;

            for (var i = 3; i < 1000; i += 3)
                sum += i;
            for (var i = 5; i < 1000; i += 5)
                sum += i;
            for (var i = 15; i < 1000; i += 15)
                sum -= i;

            return sum;
        }
    }
}
