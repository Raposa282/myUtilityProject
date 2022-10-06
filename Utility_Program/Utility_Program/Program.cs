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
            Console.WriteLine("Hello World!");
        }
    }
}
