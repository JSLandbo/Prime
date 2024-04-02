using System.Numerics;

namespace Prime.Projects
{
    internal class MersenneNumber
    {
        public static long Calc()
        {
            var result = (28433 * BigInteger.ModPow(2, 7830457, 10000000000) + 1) % 10000000000;
            var longResult = long.Parse(result.ToString());
            return longResult;
        }
    }
}
