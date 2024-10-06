namespace Task_2_12;

// Create a program that checks whether a given year is a leap year and reports the result to the user.

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a year
        Console.Write("Enter a year: ");

        // Read the year from user input and convert it to an integer
        int year = Convert.ToInt32(Console.ReadLine());

        // Check if the year is a leap year
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            // The year is a leap year
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            // The year is not a leap year
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}