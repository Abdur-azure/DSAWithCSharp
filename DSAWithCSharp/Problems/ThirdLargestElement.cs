using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class ThirdLargestElement
    {
        static int ThirdLargest(int[] arr)
        {
            int arr_size = arr.Length;
           
            if (arr_size < 3)
            {
                Console.WriteLine("Invalid Input");
                return 0;
            }
            else
            { 
                Array.Sort(arr);
                return arr[arr_size - 3];
            }
        }

        public static void ThirdLargestMain()
        {
            int[] arr = { 12, 13, 1, 10, 34, 16 };
            Console.WriteLine(ThirdLargest(arr));
        }

    }
}
