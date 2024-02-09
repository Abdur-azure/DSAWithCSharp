using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class KthElementofArray
    {
        static void KthElement(int[] a, int[] b, int n, int m , int k)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++) 
            {
                list.Add(a[i]);
            }

            for (int i = 0; i < m; i++)
            {
                list.Add(b[i]);
            }

            list.Sort();

            Console.WriteLine(list.ElementAt(k-1));
        }

        public static void KthElementMain()
        {
            int[] arr1 = { 2, 3, 6, 7, 9 };
            int[] arr2 = { 1, 4, 8, 10 };
            int k = 5;

            KthElement(arr1, arr2, arr1.Length, arr2.Length, k);
        }
    }
}
