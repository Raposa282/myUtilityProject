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
            string Choice1 = Console.ReadLine();

            if (Choice == "Calculator")
            {
                Console.WriteLine("Do you wish to add, subtract, multiply or divide?\n");
                Console.WriteLine("Enter 'Add', 'Subtract', 'Multiply' or 'Divide'.\n");
                string Choice2 = Console.ReadLine();

                Console.WriteLine("Enter the first number in the equation");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number in the equation");
                int Number2 = Convert.ToInt32(Console.ReadLine());

                int Result = Calculator(Number1, Number2, Choice2);
                Console.WriteLine("The result is " + Result + "!");
            }
        }
    }
}