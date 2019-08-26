using System;
using System.Collections.Generic;
using TextValidation;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testList = new List<string> { "a", " Z ", "Taco cat", "Taco, cat.", "Taco hat", "!a", "   mom", "Dad   .", " .," };

            Console.WriteLine("Palindrome test using extension method.");

            Console.WriteLine("Default lenght tests.");
            foreach (string text in testList)
            {
                Console.WriteLine("[{0}] : {1}.", text, text.IsPalindrome());
            }

            Console.WriteLine("Minimum length of 1 passed as parameter.");
            foreach (string text in testList)
            {
                Console.WriteLine("[{0}] : {1}.", text, text.IsPalindrome(1));
            }

            Console.WriteLine("Enter any key to exit.");
            Console.ReadKey();
        }
    }
}
