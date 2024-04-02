namespace Prime.Projects
{
    class Euler28
    {
        public static int Calc(int size)
        {
            var limit = size * size;
            var cycle = 0;
            var increase = 1;
            var sum = -2;
            for (var i = 0; i <= limit; i += increase)
            {
                if (cycle == 4)
                {
                    increase += 2;
                    cycle = 0;
                }
                cycle++;
                sum += increase + i;
            }
            return sum;
        }
    }
}
