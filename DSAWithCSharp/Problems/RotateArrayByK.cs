using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class RotateArrayByK
    {
        static void RightRotate(int[] a, int n, int k)
        {
            k = k % n;

            for (int i = 0; i < n; i++)
            {
                if( i < k )
                {
                    Console.Write(a[n + i - k] + " ");
                }
                else
                {
                    Console.Write(a[i - k] + " ");
                }
            }

        }

        public static void RightRotateMain()
        {
            int[] Array = { 1, 2, 3, 4, 5 };
            int N = Array.Length;
            int K = 2;

            RightRotate(Array, N, K);
        }
    }
}
