using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Pin Number: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            if (pin > 0)
            {
                
                bool flag = true;
                ATM atm = new ATM();

                while (flag)
                {
                    Console.WriteLine("********Welcome to ATM Service**************\n");
                    Console.WriteLine("\n1. Check Balance\n\n2. Withdraw Cash\n\n3. Deposit Cash\n\n4. Quit\n");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("YOU’RE BALANCE IN Rs: ");
                            atm.CheckBalance();
                            break;
                        case 2:
                            Console.Write("YOUR WITHDRAWAL IN Rs: ");
                            decimal windraw = Convert.ToDecimal(Console.ReadLine());
                            atm.Withdraw(windraw);
                            break;
                        case 3:
                            Console.Write("YOUR DEPOSIT IN Rs: ");
                            decimal deposit = Convert.ToDecimal(Console.ReadLine());
                            atm.Deposit(deposit);
                            break;
                        case 4:
                            Console.Write("EXIT PROGRAM");
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Pin number cannot be negative!!!");
            }
            
        }
    }
}
