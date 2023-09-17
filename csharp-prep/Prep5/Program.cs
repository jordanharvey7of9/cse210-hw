using System;

class Program

{

    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int calculatedSquaredNumber = SquaredNumber(favoriteNumber);
        DisplayResult(calculatedSquaredNumber, name);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string textFavoriteNumber = Console.ReadLine();
        // Convert textNumber to an int
        int favoriteNumber = int.Parse(textFavoriteNumber);
        return favoriteNumber;
    }
    static int SquaredNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(int squaredNumber, string userName)
    {
        //Convert squared Number to a string
        //string textSquaredNumber = squaredNumber.ToString();
        Console.WriteLine($"{userName}, the square root of your number is {squaredNumber}");
    }   

}