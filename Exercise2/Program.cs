using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\nChoose a number option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Arithmetic.AddNumbers(a, b);
                    break;
                case 2:
                    Arithmetic.SubtractNumbers(a, b);
                    break;
                case 3:
                    Arithmetic.MultiplyNumbers(a, b);
                    break;
                case 4:
                    Arithmetic.DivideNumbers(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
