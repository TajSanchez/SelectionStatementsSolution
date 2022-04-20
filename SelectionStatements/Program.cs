using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my fav number guessing game! Give me a number!");
            int favNumber = 709;
            string input = Console.ReadLine();
            int userGuess = int.Parse(input);
            
            if (userGuess == favNumber)
            {
                Console.WriteLine("Correct!");

            }
            if (userGuess < favNumber)
            {
                Console.WriteLine("Too Low... Guess again");
                
            }
            if (userGuess > favNumber)
            {
                Console.WriteLine("Too High...");
                
            }

            input = Console.ReadLine();
            userGuess = int.Parse(input);

            if (userGuess == favNumber)
            {
                Console.WriteLine("Correct!");

            }
            if (userGuess < favNumber)
            {
                Console.WriteLine("Too Low... Guess again");
                
            }
            if (userGuess > favNumber)
            {
                Console.WriteLine("Too High...");
                
            }
             input = Console.ReadLine();
             userGuess = int.Parse(input);

            if (userGuess == favNumber)
            {
                Console.WriteLine("Correct!");

            }
            if (userGuess < favNumber)
            {
                Console.WriteLine("Too Low... Guess again");
                
            }
            if (userGuess > favNumber)
            {
                Console.WriteLine("Too High...");
                
            }




        }
    }
}
