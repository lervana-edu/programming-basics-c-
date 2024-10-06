namespace Task_2_5;

// Declare two string variables firstName and lastName, concatenate them into fullName
// and display the result.

class Program
{
    static void Main(string[] args)
    {
        // Declare two string variables for first name and last name
        string firstName = "John";  // First name value
        string lastName = "Doe";    // Last name value

        // Concatenate firstName and lastName to create fullName
        string fullName = firstName + " " + lastName;  // Adding a space between first and last name

        // Display the full name
        Console.WriteLine("Full Name: " + fullName);
    }
}