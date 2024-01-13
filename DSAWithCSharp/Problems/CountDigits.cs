using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class CountDigits
    {
        public static void CountDigitsInNumber()
        {
            long n = 345289467;

            string num = Convert.ToString(n);

            Console.WriteLine(num.Length);
        }
    }
}
