using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace NumberToolkit.Operations
{
    public static class DigitOperations
    {
        public static string EveryDigit(double n)
        {
            n = Math.Floor(n);

            string s = n.ToString();

            HashSet<char> seen = new HashSet<char>();
            List<char> result = new List<char>();

            foreach (char c in s)
            {
                if (char.IsDigit(c) && !seen.Contains(c))
                {
                    seen.Add(c);
                    result.Add(c);
                }
            }

            return string.Join(", ", result);
        }

        public static float Sum(string s)
        {
            return (float)s.Where(char.IsDigit).Select(c => c - '0').Sum();
        }

        public static float Difference(string s)
        {
            float[] digits = s.Where(char.IsDigit).Select(c => (float)(c - '0')).ToArray();
            float diff = digits[0];
            for (int i = 1; i < digits.Length; i++)
                diff -= digits[i];
            return diff;
        }
    }
}