using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var fistNumber = GetIntegerFromUser();
            var secondNumber = GetIntegerFromUser();
            var symbol = GetSymbolFromUser();

            switch (symbol)
            {
                case "+":
                    Console.WriteLine(fistNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(fistNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(fistNumber * secondNumber);
                    break;
                case "/":
                    Console.WriteLine(fistNumber / secondNumber);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        static int GetIntegerFromUser()
        {
            int number;
            Console.Write("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please input a correct integer!");
            }
            return number;
        }

        static string GetSymbolFromUser()
        {
            string[] symbolArray = { "+", "-", "*", "/" };
            string symbol = "+";

            Console.Write("Enter a symbol: ");
            do
            {
                if (!symbolArray.Contains(symbol))
                {
                    Console.WriteLine("Enter a correct symbol!");
                }
                symbol = Console.ReadLine();
            }

            while (!symbolArray.Contains(symbol));

            return symbol;
        }
    }
}
