using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class CompareArrays
    {
        static bool EqualArray(int[] arr1, int[] arr2)
        {
            int N = arr1.Length;
            int M = arr2.Length;

            if (N != M)
                return false;

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < N; i++)
                if (arr1[i] != arr2[i])
                    return false;

            return true;
        }

        public static void EqualArrayMain()
        {
            int[] arr1 = { 3, 5, 2, 5, 2 };
            int[] arr2 = { 2, 3, 5, 5, 2 };

            // Function call
            if (EqualArray(arr1, arr2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
