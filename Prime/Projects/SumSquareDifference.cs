namespace Prime.Projects
{
    class SumSquareDifference
    {
        public static int Calc(int n)
        {
            var sqh = 0;
            var snh = 0;

            for (var i = 1; i <= n; i++)
                sqh += i * i;

            for (var i = 1; i <= n; i++)
                snh += i;

            return (snh * snh - sqh);
        }
    }
}
