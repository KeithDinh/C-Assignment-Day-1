using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Rows: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for(int i=1; i<=input; i++)
            {
                for (int p = 1; p <= i; p++)
                {
                    temp = (temp == 1)? 0 : 1;
                    Console.Write(temp);
                }
                Console.WriteLine("");
            }
        }
    }
}
