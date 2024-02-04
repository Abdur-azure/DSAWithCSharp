using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class TripletSumArray
    {
        static bool IsTriplet(int[] A, int arr_size, int sum)
        {
            for(int i = 0; i < arr_size - 2; i++)
            {
                for(int j = i + 1; j < arr_size - 1; j++)
                {
                    for (int k = j + 1; k < arr_size; k++)
                    {
                        if (A[i] + A[j] + A[k] == sum)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static void IsTripletMain()
        {
            int[] A = { 1, 4, 45, 6, 10, 8 };
            int sum = 22;
            int arr_size = A.Length;

            if(IsTriplet(A, arr_size, sum))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
