using System;

namespace DSAWithCSharp.Problems
{
    internal class StringAdderClass
    {
        static string StringAdder()
        {
            string input = "kjdhfjksdfh&*jshdjfhdsjkfhsd78skjdhfjsdhfkjshdj78skdhfjksdhfjkshdj89skjdhfjksdhfkjshdjkf67skjdhfkjsdhfkjsdhjfhskjd7897sjkdhfkjsdhfjksdh7dkjf8*&*&*(";
            int sum = 0;
            string currentNumber = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    currentNumber += c;
                }
                else
                {
                    if (currentNumber != "")
                    {
                        sum += int.Parse(currentNumber);
                        currentNumber = "";
                    }
                }
            }
            if (currentNumber != "")
            {
                sum += int.Parse(currentNumber);
            }
            string result = sum.ToString();

            return result;

        }
        public static void StringAdderMain() 
        {
            Console.WriteLine(StringAdder());
        }
    }
}
