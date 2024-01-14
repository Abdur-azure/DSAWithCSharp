using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class GCDOrHCF
    {
        public static void MainMethod()
        {
            int a = 98, b = 56;
            Console.WriteLine($"{GCD(a, b)}");
        }
        protected static int GCD(int a, int b)
        {
            return Math.Abs(b == 0 ? a : GCD(b, a % b));
        }
    }
}
