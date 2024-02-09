using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAWithCSharp.Problems
{
    internal class StackLearn
    {
        public static void Main()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("A");
            stack.Push("B");                
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            stack.Push("F");

            Console.WriteLine(stack);
        }
    }
}
