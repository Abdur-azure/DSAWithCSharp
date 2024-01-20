using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class PalindromeNumber
    {
        static bool CheckPalindrome(string str)
        { 
            int len = str.Length;

            for (int i = 0; i < len / 2; i++)
            { 
                if (str[i] != str[len - i - 1])
                    return false;
            }

            return true;
        }

        public static void CheckPalindromeMain()
        {
            string st = "112233445566778899000000998877665544332211";

            if (CheckPalindrome(st) == true)
                Console.Write("Yes");
            else
                Console.Write("No");
        }
    }
}
