using System;

// Create a class named MathOperations
public class MathOperations
{
    // Create a method named PerformOperation that takes two integers as parameters
    public void PerformOperation(int num1, int num2)
    {
        // Perform a math operation on num1 (for example, multiplying by 3)
        int result = num1 * 3;

        // Display the second integer to the screen
        Console.WriteLine("Result of the operation on is:" + result);
        Console.WriteLine("Second integer is: " + num2);
    }
}


class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations math = new MathOperations();

        // Call the method in the class, passing in two numbers (5 and 10)
        math.PerformOperation(5, 10);

        // Call the method in the class, specifying the parameters by name (8 and 15)
        math.PerformOperation(num1: 8, num2: 15);
    }
}
