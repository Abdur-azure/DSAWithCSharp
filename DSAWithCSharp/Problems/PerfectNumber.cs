using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class PerfectNumber
    {
        static bool IsPerfect(int n)
        {
            int sum = 1;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                        sum = sum + i + n / i;
                    else
                        sum = sum + i;
                }
            }

            if (sum == n && n != 1)
                return true;

            return false;

        }

        public static void IsPerfectMain()
        {
            for (int n = 2; n < 10000; n++)
                if (IsPerfect(n))
                    Console.WriteLine(n);
        }
    }
}
