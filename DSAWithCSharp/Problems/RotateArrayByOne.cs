using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class RotateArrayByOne
    {
        static int[] arr = new int[] { 1, 2, 3, 4, 5 };

        static void RotateArray()
        {
            int last_el = arr[arr.Length - 1], i;

            for (i = arr.Length - 1; i > 0; i--)
                arr[i] = arr[i - 1];

            arr[0] = last_el;
        }

        public static void RotateArrayMain()
        {
            Console.WriteLine("Given Array is");
            string Original_array = string.Join(" ", arr);
            Console.WriteLine(Original_array);

            // Function Call
            RotateArray();

            Console.WriteLine("Rotated Array is");
            string Rotated_array = string.Join(" ", arr);
            Console.WriteLine(Rotated_array);
        }
    }
}
