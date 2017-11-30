using System;

namespace hamster
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! Welcome to the hamster program.");
            Console.WriteLine("What is the name of your hamster?");
            string Name = Console.ReadLine();
            Console.WriteLine("What volume level?");
            int Volume = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fur color?");
            string Color = Console.ReadLine();
            Console.WriteLine("Is this hamster a good candidate for adoption?");
            bool Candidate = true;
            string Answer = Console.ReadLine();
            if(Answer == "no")
            {
                Candidate = false;
            }
            Console.WriteLine("What is the estimated age?");
            int Age;
            while (!Int32.TryParse(Console.ReadLine(), out Age))
            {
                Console.WriteLine("That was not a valid age.");
                Console.WriteLine("What is the estimated age?");
            }
            Console.WriteLine("Here are your results:");
            Console.WriteLine(Name + " is " + Age + " years old. " + Name + " can sleep with the volume at: " + Volume + ". " + Name + " has " + Color + " fur and it is " + Candidate + " that " + Name + " is a good candidate for adoption.");

            Console.ReadLine();
            
        }
    }
}
