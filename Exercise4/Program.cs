using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a <= b)
            {
                for(int i=a; i<=b; i++)
                {
                    int sum = 0;
                    int temp = i;
                    while(temp > 0)
                    {
                        int digit = temp % 10;
                        sum += Convert.ToInt32(Math.Pow(digit, 3));
                        temp /= 10;
                    }
                    if (i == sum) Console.WriteLine(sum);
                }
            }

        }
    }
}
