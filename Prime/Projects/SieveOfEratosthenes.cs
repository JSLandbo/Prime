using System;
using System.Collections.Generic;

namespace Prime.Projects
{
    class SieveOfEratosthenes
    {
        
        // Find all primes whose value does not exceed topVal
        public static List<int> SieveValueList(int topVal)
        {
            return Sieve();

            List<int> Sieve()
            {
                var list = new List<int>(); // List to hold all the prime numbers
                list.Add(2); // Add 2 here so we can i += 2 instead of i++
                var top = topVal + 1; // Define amount of numbers to check for prime
                var isPrime = RunSieve(top); // Return bool[] array which we use to check for prime
                for (var i = 3; i < top; i+=2) // Start at 3 since 2 is already added. 4, 6, 8, 10... aren't primes!
                    if (isPrime[i]) // isPrime[i] = true? Then add it!
                        list.Add(i); // list.Add(i) is slow, but the int[] alternative - although approx. same speed - was harder to understand.
                return list; // Return list of primes
            }

            bool[] RunSieve(int top)
            {
                var isPrime = new bool[top + 1]; // bool array where true of proved otherwise
                for (var i = 3; i <= top; i+=2) // 4, 6, 8.. aren't primes, so we won't waste resources to check those
                    isPrime[i] = true; // 1, 3, 5... 
                for (var i = 3; i <= top; i+=2) // Explain this :-)
                {
                    if (!isPrime[i]) continue;
                    for (var j = i * 2; j <= top; j += i)
                        isPrime[j] = false;
                }

                return isPrime;
            }
        }

        // Find all primes whose value does not exceed topVal
        public static int[] SieveValueArray(int topVal)
        {
            return SieveValueList(topVal).ToArray();
        }

        // Find amount of prime numbers
        public static List<int> SieveAmountList(int amount)
        {
            return Sieve();

            List<int> Sieve()
            {
                var list = new List<int>();
                var digits = FindDigits(amount);

                // Approx size. Not 100% but close enough.
                double sizeMult = 3;
                for (var d = 0; d < (digits - 1); d++)
                    sizeMult += 1;
                var isPrimeSize = amount * sizeMult * Math.Sqrt(digits); // Bigger than needed so we dont have to resize...
                var isPrime = RunSieve((int)isPrimeSize);

                for(var i = 2; i <= isPrime.Length-1; i++)
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

        // Find amount of prime numbers
        public static int[] SieveAmountArray(int amount)
        {
            return SieveAmountList(amount).ToArray();
        }

        // Used to find out whether or not a number is a prime
        public static bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;
            if ((n & 1) == 0)
                return false;
            if ((n % 3) == 0)
                return false;

            int i;
            var root = (int) Math.Sqrt(n);

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

        // Used to find amount of digits in a number
        public static int FindDigits(int num)
        {
            int cnt = 0;
            while (num > 0)
            {
                cnt++;
                num /= 10;
            }
            return cnt;
        }
    }
}


