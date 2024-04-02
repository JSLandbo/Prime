namespace Prime.Projects
{
    class Euler9
    {
        public static int Calc(int abc)
        {
            var product = 0;

            for(var a = 1; a <= abc; a++)
            {
                for(var b = a; (b+a) <= abc; b++)
                {
                    for(var c = b; (c + b + a) <= abc; c++)
                    {
                        if((a*a) + b*b == c * c)
                        {
                            //Console.WriteLine(a + "^2 " + b + "^2 = " + c + "^2");
                            if(a + b + c == abc)
                            {
                                return a * b * c;
                            }
                        }
                    }
                }
            }
            return product;
        }
    }
}
