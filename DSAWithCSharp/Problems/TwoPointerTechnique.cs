using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class TwoPointerTechnique
    {
        static bool PrintPairs(int[] arr, int sum)
        {
            HashSet<int> visited = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = sum - arr[i];

                if (visited.Contains(temp))
                {
                    return true;
                }

                visited.Add(arr[i]);
            }
            return false;
        }

        public static void PrintPairsMain()
        {
            int[] arr = new int[] { 1, 4, 45, 6, 10, 8 };
            int n = 16;
            if (PrintPairs(arr, n))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
