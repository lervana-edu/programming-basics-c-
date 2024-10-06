namespace Task_2_3;

// Create variables of types int, double, string, and bool. Assign appropriate values to them,
// and then display these values on the screen using Console.WriteLine().
// What values can these types store?

class Program
{
    static void Main(string[] args)
    {
        // Create an integer variable and assign a value
        int myInt = 42;  // An int can store whole numbers, positive or negative

        // Create a double variable and assign a value
        double myDouble = 3.14;  // A double can store floating-point numbers, including decimals

        // Create a string variable and assign a value
        string myString = "Hello, world!";  // A string can store a sequence of characters

        // Create a boolean variable and assign a value
        bool myBool = true;  // A bool can store true or false values

        // Using 'var' to declare variables
        // 'var' allows the compiler to determine the type based on the assigned value
        var inferredInt = 10;  // The compiler infers that this is an int
        var inferredDouble = 5.5;  // The compiler infers that this is a double

        // Display the values of the variables
        Console.WriteLine("Integer value: " + myInt);
        Console.WriteLine("Double value: " + myDouble);
        Console.WriteLine("String value: " + myString);
        Console.WriteLine("Boolean value: " + myBool);
        Console.WriteLine("Inferred Integer value (var): " + inferredInt);
        Console.WriteLine("Inferred Double value (var): " + inferredDouble);
    }
}