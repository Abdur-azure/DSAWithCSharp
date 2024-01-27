using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    public class DutchNationalFlag
    {
        static void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
        static void SortArray(int[] arr, int n)
        {
            int i, cnt0 = 0, cnt1 = 0, cnt2 = 0;

            for (i = 0; i < n; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        cnt0++;
                        break;
                    case 1:
                        cnt1++;
                        break;
                    case 2:
                        cnt2++;
                        break;
                }
            } 

            i = 0;

            while (cnt0 > 0)
            {
                arr[i++] = 0;
                cnt0--;
            }

            while (cnt1 > 0)
            {
                arr[i++] = 1;
                cnt1--;
            }

            while (cnt2 > 0)
            {
                arr[i++] = 2;
                cnt2--;
            }

            PrintArray(arr, n);
        }

        public static void SortArrayMain()
        {
            int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            int n = arr.Length;

            SortArray(arr, n);
        }

    }
}
