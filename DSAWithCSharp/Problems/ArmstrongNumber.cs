using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class ArmstrongNumber
    {
        static int NthArmstrongNumber(int n)
        {
            int count = 0;

            for (int i = 1; i <= int.MaxValue; i++)
            {
                int num = i, rem, digit = 0, sum = 0;

                num = i;

                digit = (int)Math.Log10(num) + 1;

                while (num > 0)
                {
                    rem = num % 10;
                    sum = sum + (int)Math.Pow(rem, digit);
                    num = num / 10;
                }

                if (i == sum)
                    count++;
                if (count == n)
                    return i;
            }
            return n;
        }
        public static void NthArmstrongNumberMain()
        {
            int n = 12;
            Console.WriteLine(NthArmstrongNumber(n));
        }
    }
}
