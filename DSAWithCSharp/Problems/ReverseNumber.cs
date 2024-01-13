using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class ReverseNumber
    {
        protected static void ReverseArray(int[] array, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }

        public static void ReverseAnArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            ReverseArray(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
