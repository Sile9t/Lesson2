using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!double.TryParse(args[0], out double a)) 
            {
                Console.WriteLine("First value wasn't a number");
                return;
            }
            if (!double.TryParse(args[2], out double b))
            {
                Console.WriteLine("Second value wasn't a number");
                return;
            }
            double result = 0.0;
            switch (args[1])
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Devide by zero not supported");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Unsupported operation");
                    return;
            }
            Console.WriteLine($"{a} {args[1]} {b} = {result}");
        }
    }
}
