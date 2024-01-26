using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class MissingNumber
    {
        static int GetMissingNumber(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
                total -= a[i];

            return total;
        }

        public static void GetMissingNumberMain()
        {
            int[] arr = { 1, 2, 3, 5 };
            int N = 4;
            int miss = GetMissingNumber(arr, N);
            Console.Write(miss);
        }
    }
}
