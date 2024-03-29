﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class KadanesAlgorithm
    {
        static int MaxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue, max_ending_here = 0;

            for(int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if(max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if(max_ending_here < 0)
                    max_ending_here = 0;
            }
            return max_so_far;
        }

        public static void MaxSubArraySumMain()
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.Write("Maximum contiguous sum is "
                          + MaxSubArraySum(a));
        }
    }
}
