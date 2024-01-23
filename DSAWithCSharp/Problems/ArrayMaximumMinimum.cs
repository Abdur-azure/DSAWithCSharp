using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    public struct Pair
    {
        public int min;
        public int max;
    }
    internal class ArrayMaximumMinimum
    {
        static Pair GetMinMax(int[] arr, int n)
        {
            Pair minmax = new();

            Array.Sort(arr);

            minmax.min = arr[0];

            minmax.max = arr[n - 1];

            return minmax;
        }

        public static void GetMinMaxMain()
        {
            int[] arr = { 1000, 11, 445, 1, 330, 3000 };
            int arrSize = arr.Length;

            Pair minmax = GetMinMax(arr, arrSize);

            Console.WriteLine("Minimum" + minmax.min);
            Console.WriteLine("Maximum" + minmax.max);
        }
    }
}
