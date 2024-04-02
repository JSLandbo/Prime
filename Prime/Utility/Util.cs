using System;
using System.Collections.Generic;

namespace Prime.Utility
{
    class Util
    {
        // Prime numbers

        public static List<int> CalculateAllPrimesUnderSpecificValueList(int topVal)
        {
            return Sieve();

            List<int> Sieve()
            {
                var list = new List<int>
                {
                    2
                };
                var top = topVal + 1;
                var isPrime = RunSieve(top);
                for (var i = 3; i < top; i += 2)
                    if (isPrime[i])
                        list.Add(i);
                return list; 
            }

            bool[] RunSieve(int top)
            {
                var isPrime = new bool[top + 1]; 
                for (var i = 3; i <= top; i += 2)
                    isPrime[i] = true; 
                for (var i = 3; i <= top; i += 2) 
                {
                    if (!isPrime[i]) continue;
                    for (var j = i * 2; j <= top; j += i)
                        isPrime[j] = false;
                }

                return isPrime;
            }
        }
        public static int[] CalculateAllPrimesUnderSpecificValueArray(int topVal)
        {
            return CalculateAllPrimesUnderSpecificValueList(topVal).ToArray();
        }

        public static List<int> CalculateSpecificNumberOfPrimesList(int amount)
        {
            return Sieve();

            List<int> Sieve()
            {
                var list = new List<int>();
                var digits = FindNumberOfDigitsFromInt(amount);

                // Approx size. Not 100% but close enough.
                double sizeMult = 3;
                for (var d = 0; d < (digits - 1); d++)
                    sizeMult += 1;
                var isPrimeSize = amount * sizeMult * Math.Sqrt(digits); // Bigger than needed so we dont have to resize...
                var isPrime = RunSieve((int)isPrimeSize);

                for (var i = 2; i <= isPrime.Length - 1; i++)
                {
                    if (isPrime[i])
                        list.Add(i);
                    if (list.Count >= amount)
                        break;
                }
                return list;
            }

            bool[] RunSieve(int top)
            {
                var isPrime = new bool[top + 1];
                for (var i = 2; i <= top; i++)
                    isPrime[i] = true;
                for (var i = 2; i <= top; i++)
                {
                    if (!isPrime[i]) continue;
                    for (var j = i * 2; j <= top; j += i)
                        isPrime[j] = false;
                }

                return isPrime;
            }
        }
        public static int[] CalculateSpecificNumberOfPrimesArray(int amount)
        {
            return CalculateSpecificNumberOfPrimesList(amount).ToArray();
        }

        public static bool CheckIfNumberIsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;
            if ((n & 1) == 0)
                return false;
            if ((n % 3) == 0)
                return false;

            int i;
            var root = (int)Math.Sqrt(n);

            for (i = 5; i <= root; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;

            // Multi threaded ... Slower (for some reason), but cool!
            /*
            var isPrime = true;
            Parallel.For(5, root, (index, parallelLoopState) =>
            {
                if (n % index != 0) return;
                isPrime = false;
                parallelLoopState.Stop();
            });
            return isPrime;
            */
        }

        // Fibonacci numbers

        public static List<long> CalculateFibonacciNumbersBelowValueList(long value)
        {
            if (value >= long.MaxValue) // Max val. Any more and long overflows
                return new List<long>() { -1 };

            var fibLis = new List<long>();
            long ni = 1;
            long oi = 0;
            while (true)
            {
                if (ni > value)
                    return fibLis;
                fibLis.Add(ni);
                oi = (ni += oi) - oi;
            }
        }
        public static long[] CalculateFibonacciNumbersBelowValueArray(long value)
        {
            return CalculateFibonacciNumbersBelowValueList(value).ToArray();
        }

        public static List<long> CalculateSpecificAmountOfFibonacciNumbersList(int amount)
        {
            if (amount > 92) // 92 = 7540113804746346429. Any more and long overflows.
                return new List<long>() { -1 };

            var fibLis = new List<long>();
            long ni = 1;
            long oi = 0;
            int am = 0;
            while (true)
            {
                if (am >= amount)
                    return fibLis;
                fibLis.Add(ni);
                am++;
                oi = (ni += oi) - oi;
            }
        }
        public static long[] CalculateSpecificAmountOfFibonacciNumbersArray(int amount)
        {
            return CalculateSpecificAmountOfFibonacciNumbersList(amount).ToArray();
        }

        // String to int

        public static int StringToIntTryParse(string value)
        {
            int result = 0;
            for(int i = 0; i < value.Length; i++)
            {
                result = 10 * result + value[i] - 48;
            }
            return result;
        }
        public static long StringToLongTryParse(string value)
        {
            long result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = 10 * result + value[i] - 48;
            }
            return result;
        }

        // Combine strings

        public static string StringCombine(string[] words)
        {
            return string.Concat(words);
        }
        public static string StringCombineWithSeperator(string seperator, string[] words)
        {
            return string.Join(seperator, words);
        }

        // Split string
        
        public static string[] StringSplitAtSpecificCharAndRemoveChar(char ch, string str)
        {
            return str.Split(ch);
        }

        // Number of digits in number

        public static int FindNumberOfDigitsFromInt(int num)
        {
            int cnt = 0;
            while (num > 0)
            {
                cnt++;
                num /= 10;
            }
            return cnt;
        }
        public static int FindNumberOfDigitsFromLong(long num)
        {
            int cnt = 0;
            while (num > 0)
            {
                cnt++;
                num /= 10;
            }
            return cnt;
        }

        // Occurences in strings
            
        public static int FindNumberOfSpecificCharOccurencesInAGivenString(string str, char ch)
        {
            int strlen = str.Length;
            char charToCount = ch;

            int count = 0;
            for (var i = 0; i < strlen; i++)
            {
                if(str[i] == ch)
                {
                    count++;
                }
            }

            return count;
        }
        public static int FindNumberOfSpecificStringOccurencesInAGivenString(string OuterString, string InnerString)
        {
            if (InnerString.Length > OuterString.Length)
                return 0;

            int OuterStrLen = OuterString.Length - 1;
            int InnerStrLen = InnerString.Length - 1;

            int count = 0;

            bool flag = false;

            for (var i = 0; i <= OuterStrLen; i++)
            {
                if(OuterString[i] == InnerString[0])
                {
                    for(var j = 0; j <= InnerStrLen; j++)
                    {
                        flag = true;
                        if (OuterString[i + j] == InnerString[j]) continue;
                        flag = false;
                    }
                    if (flag)
                        count++;
                }
            }

            return count;
        }

        // Math related
        
        public static int FastIntPow(int a, int b)
        {
            int c = 1;
            int i = 0;
            int maxVal = int.MaxValue;

            for (i = 0; i < b; i++)
            {
                if (c > maxVal)
                    return -1;

                c = c * a;
            }
            return c;
        }
        public static long FastLongPow(int a, int b)
        {
            long c = 1;
            long i = 0;
            int maxVal = int.MaxValue;

            for (i = 0; i < b; i++)
            {
                if (c > maxVal)
                    return -1;

                c = c * a;
            }
            return c;
        }

        public static bool FastCheckIfIntIsEven(int a)
        {
            if ((a & 1) == 0)
                return true;
            return false;
        }
        public static bool FastCheckIfLongIsEven(long a)
        {
            if ((a & 1) == 0)
                return true;
            return false;
        }
           
        public static int FastMathAbsInt(int value)
        {
            if (value > 0)
                return value;
            return value * -1;
        }
        public static long FastMathAbsLong(long value)
        {
            if (value > 0)
                return value;
            return value * -1;
        }
        public static double FastMathAbsDouble(double value)
        {
            if (value > 0)
                return value;
            return value * -1;
        }
        public static decimal FastMathAbsDecimal(decimal value)
        {
            if (value > 0)
                return value;
            return value * -1;
        }
            
        public static int MaxInt(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        public static long MaxLong(long a, long b)
        {
            if (a > b)
                return a;
            return b;
        }
        public static double MaxDouble(double a, double b)
        {
            if (a > b)
                return a;
            return b;
        }
        public static decimal MaxDecimal(decimal a, decimal b)
        {
            if (a > b)
                return a;
            return b;
        }

    }
}
