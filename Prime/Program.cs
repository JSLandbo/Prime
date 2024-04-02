using Prime.Projects;
using Prime.Utility;
using System;
using System.Diagnostics;

namespace Prime
{
    internal class Program
    {
        private static void Main()
        {
            //  Amount of execution loops
            const int loopCount = 1000;
            var watch = new Stopwatch(); 
            watch.Start();

            for (var i = 0; i < loopCount; i++)
            {
                //var SieveVal1M = SieveOfEratosthenes.SieveValueArray(1000000); // 5 ms
                //Console.WriteLine(SieveVal1M[SieveVal1M.Length - 1]);
                //
                //var SieveAmo78498 = SieveOfEratosthenes.SieveAmountArray(78498); // 7.5 ms
                //Console.WriteLine(SieveAmo78498[SieveAmo78498.Length-1]);

                //  OPG 1
                //  Nuværende løsning tager: 0.000139 ms
                //  Find all multiples of 3 and 5 under 1000 = 233168
                MultiplesOfThreeAndFive.Calc();

                //  OPG 2 
                //  Nuværende løsning tager: 0.00002838 ms 
                //  Find Sum of all even fibonacci numbers under the value of 4.000.000 = 4613732 
                EvenFibNumb.FindFibs(4000000);

                //  OPG 3
                //  Nuværende løsning tager: 0.0491 ms
                //  Find the largest prime of 600.851.475.143 = 6857 
                PrimeFactor.FindLargest(1000, 600851475143, SieveOfEratosthenes.SieveValueArray(10000));

                //  OPG 4
                //  Nuværende løsning tager: 0.0433 ms
                //  Find the largest palindrome under 999*999 = 906609
                Palindrome.Calc();

                //  OPG 5
                // Nuværende løsning tager: 53.29 ms
                // Find smallest number that can be divided by each number from 1 to 20 = 232792560
                SmallestMultiple.Calc(20);

                // OPG 6
                // Nuværende løsning tager: 0.000075 ms
                // ((1 + 2 + ... + 100)^2) - (1^2 + 2^2 ... 100^2) = 25164150
                SumSquareDifference.Calc(100);

                //  OPG 7
                //  Nuværende løsning tager: 0.74 ms
                //  Find the 10.001th prime number = 104759 
                SieveOfEratosthenes.SieveAmountArray(10001);

                //  OPG 8
                //  Nuværende løsning tager: 0.0636 ms
                //  Find the thirteen adjacent digits in the 1000-digit number that have the greatest product = 23514624000
                LargestProductInSeries.Calc(13);

                //  OPG 9
                //  Nuværende løsning tager: 13.69 ms
                //  There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc. = 31875000
                Euler9.Calc(1000);

                //  OPG 10
                //  Nuværende løsning tager: 11.5 ms
                //  Find sum of all prime numbers with value 1 to 2.000.000 = 142913828922 
                SumPrime.SumPrimeFind(2000000, SieveOfEratosthenes.SieveValueArray(2000000));

                //  OPG 12
                //  Nuværende løsning tager: 138 ms
                //  First triangular tal that has above 500 divisors = 76576500 
                TriangularNumber.TriNumCalc(500);

                //  OPG 14
                //  Nuværende løsning tager: 5.271 ms
                //  Longest Collatz sequence under 1000000 = 837799
                Euler14.Calc(1000000);

                //  OPG 16
                //  Nuværende løsning tager: 0.004541 ms
                //  Sum of the decimals in the number 2^1000 = 1366 
                PowerDigitSum.FindPower(0, 2, 1000);

                //  OPG 20
                //  Nuværende løsning tager: 0.010324 ms
                //  Find the sum of the digits in the number 100! = 
                FactorialDigitSum.Calc(100);

                //  OPG 25
                //  Nuværende løsning tager: 0.001783 ms
                //  Index of first fibonacci number to reach 1000 decimals = 4782 
                IndexFibNumb.FindFibs(1000);

                //  OPG 28
                //  Nuværende løsning tager:  0.0009253 ms
                //  What is the sum of the numbers on the diagonals in a 1001 by 1001 = 669171001
                Euler28.Calc(1001);

                //  OPG 35
                //  Nuværende løsning tager: 28.556 ms
                //  Amount of 'circular primes' under the value of 1 million = 55
                CircularPrime.CalcCircPrime(Util.CalculateAllPrimesUnderSpecificValueArray(1000000));

                //  OPG 48
                //  Nuværende løsning tager: 15.35 ms
                //  The sum of 1^1 + 2^2 ... to 1000^1000 = 9110846700
                Sumpow.Calc(10000000000, 1, 1000);

                // OPG 77
                // Nuværende løsning tager 0.02 ms [Ved 2-97 primtal]
                // What is the first value which can be written as the sum of primes in over five thousand different ways? = 71
                PrimeSummations.Calc(5000, SieveOfEratosthenes.SieveValueArray(100));

                //  OPG 97
                //  Nuværende løsning tager: 0.002987 ms
                //  Last 10 digits of 28433^7830457 + 1 = 8739992577 
                MersenneNumber.Calc(); 
            }

            watch.Stop();
            Console.WriteLine("\n\nTook on average: " + (watch.ElapsedMilliseconds/(loopCount*1.0)) + " ms");
            Console.ReadKey();
        }

    }
}
