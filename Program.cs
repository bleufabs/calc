using System;
// main menu 
class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        // Check if the program is running
        while (isRunning)
        {
            // Display the main menu
            Console.WriteLine("Welcome to the Calculator Program!");
            Console.WriteLine("Please choose an operation:");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.Write("Quit: q \n");
            string choice = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("No choice entered. Exiting the program.");
                return;
            }
            // Process user choice
            switch (choice)
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Subtract();
                    break;
                case "3":
                    Multiply();
                    break;
                case "4":
                    Divide();
                    break;
                case "q":
                    Console.WriteLine("Exiting the program.");
                    isRunning = false;
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            // Ask if the user wants to continue
            Console.Write("Do you want to perform another operation? (y/n): ");
            string continueChoice = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            if (continueChoice == "y")
            {
                isRunning = true;
            }
            else
            {
                isRunning = false;
            }
        }
    }

    // add method
    static void Add()
    {
        Console.WriteLine("You chose to add two numbers.");
        // Get user input for two numbers
        double num1 = GetUserInput("Enter the first number: ");
        double num2 = GetUserInput("Enter the second number: ");
        double result = num1 + num2;
        Console.WriteLine($"The result is {result}");
    }
    // subtract method
    static void Subtract()
    {
        Console.WriteLine("You chose to subtract two numbers.");
        // Get user input for two numbers
        double num1 = GetUserInput("Enter the first number: ");
        double num2 = GetUserInput("Enter the second number: ");
        double result = num1 - num2;
        Console.WriteLine($"The result is {result}");
    }
    // multiply method
    static void Multiply()
    {
        Console.WriteLine("You chose to multiply two numbers.");
        // Get user input for two numbers
        double num1 = GetUserInput("Enter the first number: ");
        double num2 = GetUserInput("Enter the second number: ");
        double result = num1 * num2;
        Console.WriteLine($"The result is {result}");
    }
    // divide method
    static void Divide()
    {
        Console.WriteLine("You chose to divide two numbers.");
        // Get user input for two numbers
        double num1 = GetUserInput("Enter the first number: ");
        double num2 = GetUserInput("Enter the second number: ");
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        double result = num1 / num2;
        Console.WriteLine($"The result is {result}");
    }

    // method to get user input
    static double GetUserInput(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                Console.Write("Invalid input. Please enter a number: ");
            }
        }
    }
}
