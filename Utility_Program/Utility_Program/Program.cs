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
            Console.WriteLine("Hello World!");
        }
    }
}
