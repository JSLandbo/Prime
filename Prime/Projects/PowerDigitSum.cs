using System.Linq;
using System.Numerics;

namespace Prime.Projects
{
    internal class PowerDigitSum
    {
        public static int FindPower(int s, int t1, int t2)
        {
            var chrArr = BigInteger.Pow(t1, t2).ToString().ToCharArray();
            s += chrArr.Sum(b => (b - '0'));
            return s;
        }
    }
}
