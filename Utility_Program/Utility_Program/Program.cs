using System;

namespace Utility_Program
{
    class Program
    {
        double Calculator(int a, int b, string action)
        {
            if (action == "Add")
            {
                return a + b;
            }
            else if (action == "Subtract")
            {
                return a - b;
            }
            else if (action == "Multiply")
            {
                return a * b;
            }
            else if (action == "Divide")
            {
                return a / b;
            }
            return 0;
        }

        int Converter(int farenheit)
        {
            string a = "subtract";
            string b = "divide";
            int total = 0;

            int celsius = Calculator( farenheit,30, a);
            total = Calculator(celsius, 2, b);
            return total;
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

                double Result = Calculator(Number1, Number2, Choice2);
                Console.WriteLine("The result is " + Result + "!");
            }
        }
    }
}