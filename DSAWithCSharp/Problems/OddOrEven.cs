using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class OddOrEven
    {
        public static void IsEven()
        {
            int a = 4;

            if (a == (a >> 1) << 1)
            {
                Console.WriteLine("Number " + a + " is even.");
            }
            else
            {
                Console.WriteLine("Number " + a
                                  + " is not even.");
            }

            // below is short hand 
            // a==(a>>1)<<1? printf("Number %d is 
            // even.\n",a):printf("Number %d is odd.\n",a); 
        }
    }
}
