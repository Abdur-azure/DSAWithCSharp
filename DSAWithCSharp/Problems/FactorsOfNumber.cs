using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class FactorsOfNumber
    {
        public static void Factors()
        {
            int a = 100;

            for (int i = 1; i <= a; i++)
                if (a % i == 0)
                    Console.Write( i + " " );
        }
    }
}
