namespace Task_2_6;

// Write a program that calculates the area of a rectangle using dimensions stored in variables
// x and y. The result should be stored in variable z and then displayed.

class Program
{
    static void Main(string[] args)
    {
        // Declare two variables for the dimensions of the rectangle
        double x = 5.0;  // Length of the rectangle
        double y = 3.0;  // Width of the rectangle

        // Calculate the area and store the result in variable z
        double z = x * y;  // Area = length * width

        // Display the area
        Console.WriteLine("The area of the rectangle is: " + z);
    }
}