namespace Task_2_4;

// Declare two int variables a and b, and perform addition, subtraction, multiplication and division.
// Display the results of each operation.

class Program
{
    static void Main(string[] args)
    {
        // Declare two integer variables and assign values
        int a = 15;  // First integer value
        int b = 5;   // Second integer value

        // Perform addition
        int additionResult = a + b;  // Add a and b
        Console.WriteLine("Addition (a + b): " + additionResult);

        // Perform subtraction
        int subtractionResult = a - b;  // Subtract b from a
        Console.WriteLine("Subtraction (a - b): " + subtractionResult);

        // Perform multiplication
        int multiplicationResult = a * b;  // Multiply a by b
        Console.WriteLine("Multiplication (a * b): " + multiplicationResult);

        // Perform division
        int divisionResult = a / b;  // Divide a by b
        Console.WriteLine("Division (a / b): " + divisionResult);
    }
}