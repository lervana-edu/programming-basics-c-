namespace Task_2_7;

// Write a program that converts a value in PLN to USD and EUR. Declare the following variables:
// - pln: value in PLN
// - usdRate: USD exchange rate
// - eurRate: EUR exchange rate
// Calculate the converted values and display the results.

class Program
{
    static void Main(string[] args)
    {
        // Declare variables for PLN value and exchange rates
        double pln = 100.0;        // Amount in PLN
        double usdRate = 4.0;      // USD exchange rate (1 USD = 4 PLN)
        double eurRate = 4.5;      // EUR exchange rate (1 EUR = 4.5 PLN)

        // Calculate the value in USD and EUR
        double usdValue = pln / usdRate;  // PLN to USD conversion
        double eurValue = pln / eurRate;  // PLN to EUR conversion

        // Display the results
        Console.WriteLine("PLN value: " + pln);
        Console.WriteLine("Value in USD: " + usdValue);
        Console.WriteLine("Value in EUR: " + eurValue);
    }
}