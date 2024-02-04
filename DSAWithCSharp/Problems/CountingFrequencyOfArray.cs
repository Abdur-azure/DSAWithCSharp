using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class CountingFrequencyOfArray
    {
        static void CountFrequency(int[] arr, int n)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    var value = map[arr[i]];
                    map.Remove(arr[i]);
                    map.Add(arr[i], value + 1);
                }
                else
                {
                    map.Add(arr[i], 1);
                }
            }

            foreach(KeyValuePair<int, int> kvp in map)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }

        public static void CountFrequencyMain()
        {
            int[] arr = { 10, 20, 20, 10, 10, 20, 5, 20 };
            int n = arr.Length;
            CountFrequency(arr, n);
        }
    }
}
