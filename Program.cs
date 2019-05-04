using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "Y";

            Console.WriteLine("Welcome to the Factorial Calculator!");

            while(!cont.Equals("N") && !cont.Equals("n"))
            {
                Console.WriteLine("Please enter number you would like to find factorial for: ");
                int num = Convert.ToInt32(Console.ReadLine());

                try
                {
                    if (num < 0 || num > 10)
                    {
                        Console.WriteLine("Invalid input please try again!");
                        continue;
                    }
                    Console.WriteLine("The factorial of " + num + " is " + factorial(num));

                    Console.WriteLine("Would you like to continue?y/n: ");
                    cont = Console.ReadLine();
                }
                catch(Exception)
                {
                    Console.WriteLine("Error! Please try again!");
                    continue;
                }
            }
            Console.WriteLine("Goodbye!");
        }

        public static int factorial(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            return num * factorial(num-1);
        }
    }
}
