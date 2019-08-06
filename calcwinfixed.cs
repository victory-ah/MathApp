using System;

namespace CalculatorWin
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0; double num2 = 0;

            Console.WriteLine(" Console Calculator\n " );
            Console.WriteLine(" Type a number, then press Enter " );
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type another number, then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Choose an option from the following list: ");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("What's your next option?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Thanks for stopping by!");
                    return;
            }

            while (num2 == 0)
            {
                Console.WriteLine("Division by 0 isn't valid, please try another number ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }

            //if user inputs something other than a math operator the program writes
            // to the screen "Thanks for stopping by!" and exists. 

            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            Console.WriteLine("Press any key to close the Calculator console app..." );
            Console.ReadKey();

        }
    }
}
