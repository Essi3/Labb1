using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            string option;

            Console.WriteLine("CALCULATOR");
            do
            {
                
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Multiply two numbers");
                Console.WriteLine("3. Sum the numbers between two numbers");
                Console.WriteLine("4. Add number to memory");
                Console.WriteLine("5. Clear memory");
                Console.WriteLine("6. Print calculator contents");
                Console.WriteLine("7. Quit");
                Console.Write("Please enter an option: ");
                option = Console.ReadLine();
                Console.WriteLine();
                MenuOption(option, calculator);
            } while (option != "7");
        }

        private static void MenuOption(string option, Calculator calculator)
        {
            switch (option)
            {
                case "1":
                    //add two numbers
                    TakeUserInput(calculator);
                    Console.WriteLine("{0} + {1} = {2}\n", calculator.FirstNumber, calculator.SecondNumber, calculator.SumNumbers());
                    break;
                case "2":
                    //multiply two numbers
                    TakeUserInput(calculator);
                    Console.WriteLine("{0} * {1} = {2}\n", calculator.FirstNumber, calculator.SecondNumber, calculator.MultiplyNumbers());
                    break;
                case "3":
                    //sum between numbers
                    TakeUserInput(calculator);
                    Console.WriteLine("{0}...{1} = {2}\n", calculator.FirstNumber, calculator.SecondNumber, calculator.SumInBetween());
                    break;
                case "4":
                    //save number in memory
                    Console.Write("Insert number to save: ");
                    calculator.NumberInMemory = int.Parse(Console.ReadLine());
                    Console.WriteLine("Number {0} successfully added to memory\n", calculator.NumberInMemory);
                    break;
                case "5":
                    //reset memory to 0
                    calculator.NumberInMemory = 0;
                    Console.WriteLine("Number in memory cleared\n");
                    break;
                case "6":
                    //print numbers in memory
                    Console.WriteLine(calculator.ToString());
                    break;
                case "7":
                    // quit calculator
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again?");
                    break;
            }
        }

        private static void TakeUserInput(Calculator calculator)
        {
            Console.Write("First number: ");
            calculator.FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            calculator.SecondNumber = int.Parse(Console.ReadLine());
        }
    }
}