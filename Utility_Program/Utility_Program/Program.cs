using System;

namespace Utility_Program
{
    class Program
    {
        int Calculator(int a, int b, string action)
        {
            if (action == "add")
            {
                return a + b;
            }
            else if (action == "subtract")
            {
                return a - b;
            }
            else if (action == "multiply")
            {
                return a * b;
            }
            else if (action == "divide")
            {
                return a / b;
            }
        }

        int Converter(int farenheit)
        {
            int celsius = farenheit - 30;
            return celsius / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Do you wish to use the the calculator or the Fahrenheit to Celsius converter?\n");
            Console.WriteLine("Enter 'Calculator' for the former and 'Converter' for the latter.\n");
            string Choice = Console.ReadLine();

            if (Choice == "Calculator")
            {
                Console.WriteLine("Do you wish to add, subtract, multiply or divide?\n");
                Console.WriteLine("Enter 'Add', 'Subtract', 'Multiply' or 'Divide'.\n");
            }
        }
    }
}