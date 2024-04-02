namespace Prime.Projects
{
    internal class EvenFibNumb
    {
        public static int FindFibs(int amount)
        {
            var sum = 0;
            var ni = 1;
            var oi = 0;
            while (true)
            {
                if (ni > amount)
                    break;
                if ((ni&1) == 0)
                    sum += ni;
                
                oi = (ni += oi) - oi;
            }

            return sum;
        }
    }
}
