using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Arithmetic
    {
        public static void AddNumbers(int a, int b)
        {
            Console.WriteLine($"Sum = {a + b}");
        }
        public static void AddNumbers(double a, double b)
        {
            Console.WriteLine($"Sum = {a + b}");
        }
        public static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine($"Subtract = {a - b}");
        }
        public static void SubtractNumbers(double a, double b)
        {
            Console.WriteLine($"Subtract = {a - b}");
        }
        public static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine($"Multiply = {a * b}");
        }
        public static void MultiplyNumbers(double a, double b)
        {
            Console.WriteLine($"Multiply = {Math.Round(a * b, 4)}");
        }
        public static void DivideNumbers(double a, double b)
        {
            Console.WriteLine($"Division = {Math.Round(a / b, 4)}");
        }
    }
}
