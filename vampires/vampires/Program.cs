using System;
using System.Collections.Generic;

namespace vampires
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> Alias = new Dictionary<string, bool>()
            {
                {"yes", true },
                {"Yes", true },
                {"y", true },
                {"no", false },
                {"No", false },
                { "n", false }
            };

            Console.WriteLine("How many employees are we processing today?");
            int Process = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < Process; i++)
            {
                Console.WriteLine("Hi, welcome to Werewolf Inc. What's your name?");
                string Name = Console.ReadLine();
                Console.WriteLine("How old are you?");
                int Age;
                int Tries = 0;
                while (!Int32.TryParse(Console.ReadLine(), out Age) || Tries > 2)
                {
                    if (Tries > 2)
                    {
                        Console.WriteLine("Thank you for your time. This interview is over.");
                        break;
                    }
                    Console.WriteLine("That was an invalid age. Please enter a number, like 60.");
                    Tries += 1;
                }
                Console.WriteLine("What year were you born?");
                int Year = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Our cafeteria serves garlic bread. Should we order you some?");
                bool GarlicBread = Alias[Console.ReadLine()];
                Console.WriteLine("Would you like to enroll in the company's health insurance?");
                bool Health = Alias[Console.ReadLine()];

                Console.WriteLine("We are evaluating your results.");
                System.Threading.Thread.Sleep(2000);

                // Detection Logic
                bool Hired = false;
                bool Check = false;
                int TrueAge = 2017 - Year;
                string Result;

                if (TrueAge == Age && (GarlicBread || Health))
                {
                    Hired = true;
                    Check = true;
                    Result = "Probably not a vampire";
                }
                if (TrueAge != Age && (!GarlicBread || !Health))
                {
                    Check = true;
                    Hired = false;
                    Result = "Probably a vampire.";
                }
                if (TrueAge != Age && !GarlicBread && !Health)
                {
                    Check = true;
                    Hired = false;
                    Console.WriteLine("Most Certainly a vampire.");
                }
                if (Name == "Drake Cula" || Name == "Tu Fang")
                {
                    Check = true;
                    Hired = false;
                    Console.WriteLine("Definitely a vampire.");
                }
                if (!Check)
                {
                    Console.WriteLine("Results inconclusive.");
                }

                if (Hired)
                {
                    Console.WriteLine("You're hired! Congrats!");
                }
                else
                {
                    Console.WriteLine("Thank you for your time. We have decided to move forward with other candidates.");
                }
            }
            Console.ReadLine();
        }
    }
}
