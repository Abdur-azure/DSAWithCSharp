using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class FirstAndLastDigit
    {
        public static void WhatIsFirstAndLastDigit()
        {
            int n = 34356;
            string s = n.ToString();
            int first_digit = s[0] - '0';
            int last_digit = s[s.Length - 1] - '0';
            Console.WriteLine("First digit of {0} is {1}", n, first_digit);
            Console.WriteLine("Last digit of {0} is {1}", n, last_digit);
        }
    }
}
