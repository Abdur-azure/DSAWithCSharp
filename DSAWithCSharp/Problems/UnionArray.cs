using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class UnionArray
    {
        static void MakeUnion(int[] a, int n, int[] b, int m)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < n; i++)
                set.Add(a[i]);

            for (int i = 0;i < m; i++)
                set.Add(b[i]);

            foreach (int i in set)
                Console.Write(i + " ");
        }

        public static void MakeUnionMain()
        {
            int[] a = { 1, 2, 5, 6, 2, 3, 5, 7, 3 };
            int[] b = { 2, 4, 5, 6, 8, 9, 4, 6, 5, 4 };

            MakeUnion(a, a.Length, b, b.Length);
        }
    }
}
