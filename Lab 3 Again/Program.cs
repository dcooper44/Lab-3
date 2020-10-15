using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int realNumber = 0;
            bool stillPlaying = true;

            Console.WriteLine("Hello! Please Enter Your Name");
            string userName = Console.ReadLine();
            while (stillPlaying)
            {
                Console.WriteLine("Hello {0}! Please Enter a Positive Number Between 1-100", userName);
                string userNumber = Console.ReadLine();
                bool validInput = int.TryParse(userNumber, out realNumber);


                if (validInput == false)
                {
                    Console.WriteLine("{0}, Your Entry of {1} is Invalid. Please Enter a Positive Number Between 1 and 100", userName, userNumber);
                    continue;
                }

                else if (realNumber < 1 || realNumber > 100)
                {
                    Console.WriteLine("{0}, Your Entry of {1} is Invalid. Please Enter a Positive Number Between 1 and 100", userName, userNumber);
                    continue;
                }
                else
                {
                    if (realNumber % 2 > 0)
                    {
                        Console.WriteLine("{0} Odd.", userNumber);
                        stillPlaying = false;
                    }
                    else if (realNumber % 2 == 0 && (realNumber > 0 && realNumber <= 25))
                    {
                        Console.WriteLine("Even and less than 25.");
                        stillPlaying = false;
                    }
                    else if (realNumber % 2 == 0 && (realNumber > 25 && realNumber <= 60))
                    {
                        Console.WriteLine("Even.");
                        stillPlaying = false;
                    }
                    else if (realNumber % 2 == 0 && (realNumber > 25 && realNumber <= 60))
                    {
                        Console.WriteLine("Even.");
                        stillPlaying = false;
                    }
                    Console.WriteLine("Would You Like To Play Again? (Yes/No) ");

                    string userBored = Console.ReadLine();

                    if (userBored.Equals("yes", StringComparison.OrdinalIgnoreCase) || userBored.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {
                        stillPlaying = true;
                        continue;
                    }
                    else
                    {
                        stillPlaying = false;
                    }

                }
                Console.WriteLine("Thank You {0} For Playing!", userName);
            }
        }
    }
}