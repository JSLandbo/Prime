using System.Numerics;
namespace Prime.Projects
{
    internal class Sumpow
    {
        public static long Calc(long digs, int start, int end)
        {
            var sum = new BigInteger();
            for(var i = start; i<= end; i++)
                sum += BigInteger.Pow(i,i);
            sum %= digs;
            var returnVal = long.Parse(sum.ToString()); // Last 10 digits of sum
            return returnVal;
        }
    }
}
