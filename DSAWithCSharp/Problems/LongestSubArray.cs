using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class LongestSubArray
    {
        static int MaxConsecutiveSubArray(int[] arr, int max)
        {
            int maxi = 0;

            for(int i  = 0; i < max - 1; i++)
            {
                int cnt = 1, j;

                for(j = i; j < max - 1; j++) 
                {
                    if (arr[j + 1] == arr[j] + 1)
                    {
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }

                maxi = Math.Max(maxi, cnt);
                i = j;
            }

            return maxi;
        }

        public static void MaxConsecutiveSubArrayMain()
        {
            int max = 11;
            int[] arr = { 1, 3, 4, 2, 3, 4, 2, 3, 5, 6, 7 };

            Console.WriteLine(MaxConsecutiveSubArray(arr, max));
        }
    }
}
