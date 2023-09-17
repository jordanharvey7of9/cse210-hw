using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        string textMagicNumber = Console.ReadLine();
        int magicNumber = int.Parse(textMagicNumber);*/

        Random randomGenerator = new Random ();
        int magicNumber = randomGenerator.Next (1,100);
        int guessNumber = 0;
        
        do
        {

        Console.WriteLine("What is your guess? ");
        string textGuessNumber = Console.ReadLine();
        guessNumber = int.Parse(textGuessNumber);


        if (magicNumber > guessNumber)
        {
            Console.WriteLine("Higher");
        }

        else if (magicNumber < guessNumber)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.Write("You guessed it!");
        }

        } while (magicNumber != guessNumber);
    }
}