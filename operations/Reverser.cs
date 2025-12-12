using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace NumberToolkit.Operations
{
    public static class Reverser
    {
        public static string Reverse(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}