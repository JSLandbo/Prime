using System.Linq;
using System.Numerics;

namespace Prime.Projects
{
    class FactorialDigitSum
    {
        public static long Calc(int num)
        {
            BigInteger full = num;
            for (var i = num; i >= 1; i--)
                full = full * i;
            return full.ToString().Sum(c => c - '0');
        }
    }
}
