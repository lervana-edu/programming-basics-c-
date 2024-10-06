namespace Task_2_11;

// Write a program that checks whether a given integer is even or odd and displays
// an appropriate message.

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter an integer
        Console.Write("Enter an integer: ");
        
        // Read the value from the user and convert it to an integer type
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is even using the modulo operator (%)
        if (number % 2 == 0)
        {
            // If the remainder is 0, the number is even
            Console.WriteLine("The number is even.");
        }
        else
        {
            // If the remainder is not 0, the number is odd
            Console.WriteLine("The number is odd.");
        }
    }
}