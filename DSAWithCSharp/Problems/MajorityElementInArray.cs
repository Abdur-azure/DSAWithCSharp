using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class MajorityElementInArray
    {
        static void MajorityElement(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    int count = map[arr[i]] + 1;
                    if (count > arr.Length / 2)
                    {
                        Console.WriteLine(arr[i]);
                        return;
                    }
                    else
                    {
                        map[arr[i]] = count;
                    }
                }
                else
                {
                    map[arr[i]] = 1;
                }
            }

            Console.WriteLine("No Majority Element");
        }

        public static void MajorityElementMain()
        {
            int[] a = new int[]{2, 2, 2, 2,
                        5, 5, 2, 3, 3};

            MajorityElement(a);
        }
    }
}
