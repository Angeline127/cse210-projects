using System;

namespace Prep3

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 3");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);

            string  keepPlaying = "yes";
            int guessCount = 0;
            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount = guessCount + 1;

                if (magicNumber < guess )
                {
                    Console.WriteLine("Higher");
                }
                else if(magicNumber > guess)
                {
                    Console.WriteLine("lower");
                }
                else 
                {
                    Console.WriteLine("You guessed right!");
                }
            }
                Console.WriteLine($"It took you {guessCount}" );

                Console.WriteLine("Would you like to play again(yes/no)? ");
                keepPlaying = Console.ReadLine();

                


            Console.WriteLine("Thanks you for playing. Goodbye.");
        }
    }
}
