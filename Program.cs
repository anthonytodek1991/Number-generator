using System;

namespace Lab_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Number Generator!!");

            Console.WriteLine("User, what is your name?");

            String UserName = Console.ReadLine();

            // User is directed to enter an integer between 1 and 100

            string Continue;
            /* initiate do loop execution*/
            do
            {
                Console.WriteLine("Please Enter a number from 1 - 100");
                String UserInput = Console.ReadLine();


                int i = int.Parse(UserInput);

                // Once first parameter is met, the program will test against the other "if's"

                if (i % 2 == 0 && i <= 100)
                {
                    Console.WriteLine("{0} Even ", i);

                    if (i > 2 && i <= 25)
                    {
                        Console.WriteLine("{0} Even and less than 25", i);
                    }

                    else if (i >= 26 && i <= 60)
                    {
                        Console.WriteLine("{0} Even", i);
                    }

                    else if (i >= 60)
                    {
                        Console.WriteLine("{0} Even and Greater than 60", i);
                    }
                }

                // If user input does not meet any of the If statements, it will test against the else

                else
                {
                    Console.WriteLine("{0} Odd", i);

                    if (i >= 60 && i <= 100)
                    {
                        Console.WriteLine("{0} Odd", i);
                    }
                }

                // User is prompted to continue, the program will terminate only if user does not wish to continue

                Console.WriteLine("Continue? (Y/N):");
                Continue = Console.ReadLine().ToLower();
            } while (Continue == "y"||Continue == "yes");
            Console.WriteLine("Goodbye for now!");
        }
    }
}