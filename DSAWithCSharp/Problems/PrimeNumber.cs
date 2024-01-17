using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class PrimeNumber
    {
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        public static void IsPrimeMain()
        {
            if (IsPrime(11))
                Console.Write("is Prime");

            else
                Console.Write("not prime");
        }
    }
}
