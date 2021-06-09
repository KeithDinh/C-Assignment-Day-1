using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int longest = 2 * input + 1;
            int spaceEachSide = 1;
            string output = "";

            char[] c = new char[longest];
            for (int i=longest; i>0; i-=2)
            {
                if(i == longest)
                {
                    Array.Fill(c, '*');
                    output += new string(c) + '\n';
                }
                else
                {
                    for(int j=0; j< spaceEachSide; j++)
                    {
                        c[j] = ' ';
                        c[longest - 1 - j] = ' ';
                    }
                    spaceEachSide++;
                    output = new string(c) + '\n' + output + new string(c) + '\n';
                }
                
            }
            Console.WriteLine(output);
        }
    }
}
