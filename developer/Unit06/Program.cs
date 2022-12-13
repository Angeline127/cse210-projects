using System;

namespace Unit06
{
    class RandomNumber : System.Object
    {
        private Random random;

        public RandomNumber()
        {
            this.random = new Random();
        }

        public int Generate(int min, int max)
        {
            return this.random.Next(min, max);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a random number
    RandomNumber randomNumber = new RandomNumber();

    //
    int number = randomNumber.Generate(1, 51);
    int count = 1;

    while (true)
    {
      Console.Write("Enter a number between 1 and 100(0 to quit): ");
      //Check if number is 0 or not
      int input = Convert.ToInt32(Console.ReadLine());
      if (input == 0)
        return;
      // Check if number is higer or lower
      else if (input < number)
      {
        Console.WriteLine("Too low, try again.");
        ++count;
        continue;
      }
      else if (input > number)
      {
        Console.WriteLine("Too high, try again.");
        ++count;
        continue;
      }
      else
      {
         Console.WriteLine("You guessed it! The number was {0}!", randomNumber);
          Console.WriteLine("It took you {0} {1}.\n", count, count == 1 ? "try" : "tries");
          break;
      }
    }
        }
    }
}
