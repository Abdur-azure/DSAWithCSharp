using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class RemoveDulplicatesInArray
    {
        static void RemoveDuplicate(int[] arr, int n)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0;i < n; i++)
            {
                set.Add(arr[i]);
            }

            foreach (int i in set) 
            {
                Console.Write(i + " ");
            }
        }

        public static void RemoveDuplicatesMain()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            int n = arr.Length;

            RemoveDuplicate(arr, n);
        }
    }
}
