// See https://aka.ms/new-console-template for more information

using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        Console.Write("Select operation (1/2/3/4): ");
        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case '1':
                result = Add(num1, num2);
                break;
            case '2':
                result = Subtract(num1, num2);
                break;
            case '3':
                result = Multiply(num1, num2);
                break;
            case '4':
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a valid operation.");
                return;
        }

        Console.WriteLine($"{num1} {GetOperationSymbol(choice)} {num2} = {result}");
    }

    static double Add(double x, double y)
    {
        return x + y;
    }

    static double Subtract(double x, double y)
    {
        return x - y;
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }

    static double Divide(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
    }

    static char GetOperationSymbol(char choice)
    {
        switch (choice)
        {
            case '1':
                return '+';
            case '2':
                return '-';
            case '3':
                return '*';
            case '4':
                return '/';
            default:
                return ' ';
        }
    }
}
