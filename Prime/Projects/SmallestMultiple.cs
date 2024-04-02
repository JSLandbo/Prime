namespace Prime.Projects
{
    class SmallestMultiple
    {
        public static int Calc(int limit)
        {
            for (var i = limit;; i += limit)
            {
                var t = true;
                for (var j = limit; j >= 2; j--)
                {
                    if (i % j == 0) continue;
                    t = false;
                    break;
                }
                if (!t) continue;
                return i;
            }
        }
    }
}
