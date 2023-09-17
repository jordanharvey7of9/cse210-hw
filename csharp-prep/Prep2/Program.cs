    using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        float grade = float.Parse(gradePercentage);

        string letter = "A";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"{letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("You failed.  Try again.");
        }

    }
}