using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class SquareRoot
    {
        static int FindSquareRoot(int x)
        {
            double result = Math.Exp(Math.Log(x) / 2);

            int floorResult = (int)Math.Floor(result);

            return floorResult;
        }

        public static void FindSquareRootMain()
        {
            int x = 11;
            Console.WriteLine(FindSquareRoot(x));
        }
    }
}
