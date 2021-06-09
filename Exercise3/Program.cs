using System;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string to reverse: ");
            string input = Console.ReadLine();
            string reversed = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine($"String after reverse: {reversed}");

        }
    }
}
