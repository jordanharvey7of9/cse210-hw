using System;

class Program
{
    static void Main(string[] args)
    {
        // Create list of numbers named "numbers"
        List<int> numbers = new List<int>();
        //Prompt the user to enter numbers, stop when 0 is entered        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        
        do
        {
            Console.Write("Enter number: ");
            // Convert inputed string to an int
            string textNumber = Console.ReadLine();
            number = int.Parse(textNumber);
            // Add number to list of numbers
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Calculate the total number of numbers in the Numbers List    
        int countNumbers = (numbers.Count); 

        // Calculate the sum of numbers in the Numbers List
        float sumNumbers = (numbers.Sum());

        // Calulcate the average number in the Numbers List
        float averageNumbers = (sumNumbers/countNumbers);

        // Figure out the biggest number in the Numbers List
        int maxNumber = (numbers.Max());

        // Using the Numbers List print: sum, average, biggest number
        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {averageNumbers}");
        Console.WriteLine($"The largest numbers is: {maxNumber}");
    




    }
}