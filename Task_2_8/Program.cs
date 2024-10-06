namespace Task_2_8;

// Write a program that calculates the area of a rectangle. The values of sides a and b should be "random". 
// Variables representing these values should be of type double. Display the result with a precision of
// two decimal places.

class Program
{
    static void Main(string[] args)
    {
        // Create a Random object to generate random values
        Random random = new Random();

        // Generate random double values for sides a and b between 1.0 and 10.0
        double a = random.NextDouble() * 9.0 + 1.0;  // Generates a value in the range [1.0, 10.0]
        double b = random.NextDouble() * 9.0 + 1.0;  // Generates a value in the range [1.0, 10.0]

        // Calculate the area of the rectangle
        double area = a * b;

        // Display the result with two decimal places
        Console.WriteLine("Side a: " + a.ToString("F2"));
        Console.WriteLine("Side b: " + b.ToString("F2"));
        Console.WriteLine("Area of the rectangle: " + area.ToString("F2"));
        
        // Display the result with two decimal places using Convert
        Console.WriteLine("Side a: " + Convert.ToDouble(Math.Round(a, 2)));
        Console.WriteLine("Side b: " + Convert.ToDouble(Math.Round(b, 2)));
        Console.WriteLine("Area of the rectangle: " + Convert.ToDouble(Math.Round(area, 2)));
    }
}