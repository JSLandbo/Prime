using Prime.Utility;

namespace Prime.Projects
{
    
    internal class CircularPrime
    {
        public static int CalcCircPrime(int[] list)
        {
            var count = 0;
            var flag = true;
            for (var i = 0; i <= (list.Length - 1); i++)
            {
                var rot = Rotations(list, list[i]);
                for (var j = 0; j <= (rot.Length - 1); j++)
                {
                    flag = true;
                    if (SieveOfEratosthenes.IsPrime(rot[j])) continue;
                    flag = false;
                    break;
                }
                if (flag)
                    count++;
            }
            return count;
        }

        public static int[] Rotations(int[] arr, int ele)
        {
            var str = ele.ToString();
            int digits = str.Length - 1;
            var rotations = new int[digits + 1];

            for (var i = 0; i <= digits; i++)
            {
                str = str[digits] + str.Substring(0, digits);
                rotations[i] = Util.StringToIntTryParse(str);

                if ((rotations[i] & 1) == 0) break;
                if ((rotations[i] % 3) == 0) break;
                if ((rotations[i] % 5) == 0) break;
            }
            return rotations;
        }
    }
}
