using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Weclome to the game of all games, Guess the magic number!");
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1,100);

       int guess = -1;

       while (guess != magicNumber)
       {
           Console.Write("What is your guess? ");
           guess = int.Parse(Console.ReadLine());
    
            if (magicNumber > guess) 
        {
                Console.WriteLine("Higher");
        }
            else if (magicNumber < guess)
        {
                Console.WriteLine("Lower");
        }
            else
        {
                Console.WriteLine("Congradulations, you are wicked smart.");
        }
       }
    }
}