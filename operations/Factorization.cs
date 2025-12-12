using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace NumberToolkit.Operations
{
    public static class Factorization
    {
        public static List<long> GetFactors(long n)
        {
            var factors = new List<long>();

            for (long i = 1; i <= Math.Abs(n); i++)
            {
                if (n % i == 0)
                    factors.Add(i);
            }

            return factors;
        }

        public static bool CheckPrime(long n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            long limit = (long)Math.Sqrt(n);
            for (int i = 5; i <= limit; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static List<long> PrimeFactorization(long n)
        {
            var result = new List<long>();
            n = Math.Abs(n);

            while (n % 2 == 0)
            {
                result.Add(2);
                n /= 2;
            }

            for (int i = 3; i < Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    result.Add(i);
                    n /= i;
                }
            }

            if (n > 2) result.Add(n);
            
            return result;
        }
    }
}