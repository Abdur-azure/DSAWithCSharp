using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class InversionCountOfArray
    {
        static int InversionCount(int[] arr, int n)
        {
            int inv_count = 0;

            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                        inv_count++;
                }
            }

            return inv_count;
        }

        public static void InversionCountMain()
        {
            int[] arr = { 1, 20, 6, 4, 5 };
            int n = arr.Length;

            Console.WriteLine("Number of Inversion are: " + InversionCount(arr, n));
        }
    }
}
