namespace Task_2_13;

// Write a program that converts a temperature from Celsius to Fahrenheit or vice versa,
// depending on the setting of a bool flag.

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the temperature
        Console.Write("Enter the temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        // Define the conversion flag: true for Celsius to Fahrenheit, false for Fahrenheit to Celsius
        Console.Write("Enter 'C' to convert from Celsius to Fahrenheit or 'F' to convert from Fahrenheit to Celsius: ");
        string input = Console.ReadLine().ToUpper();
        bool isCelsiusToFahrenheit = input == "C";

        // Check the flag and perform the conversion accordingly
        if (isCelsiusToFahrenheit)
        {
            // Convert from Celsius to Fahrenheit
            double fahrenheit = (temperature * 9 / 5) + 32;
            Console.WriteLine($"{temperature}°C is equivalent to {fahrenheit:F2}°F");
        }
        else
        {
            // Convert from Fahrenheit to Celsius
            double celsius = (temperature - 32) * 5 / 9;
            Console.WriteLine($"{temperature}°F is equivalent to {celsius:F2}°C");
        }
    }
}