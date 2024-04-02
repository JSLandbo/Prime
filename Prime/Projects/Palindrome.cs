namespace Prime.Projects
{
    class Palindrome
    {
        public static int Calc()
        {
            var l = 0;

            for (var i = 999; i >= 900; i--)
            {
                for (var j = 999; j >= i; j--)
                {
                    if (!CheckPalin(i * j)) continue;
                    if(l > i * j) continue;
                    l = i * j;
                }
            }
            return l;
        }

        public static bool CheckPalin(int num)
        {
            var n = num;
            var rev = 0;
            while (num > 0)
            {
                var dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }
            return n == rev;
        }
    }
}
