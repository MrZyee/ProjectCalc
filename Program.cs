using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Calculator calculator = new Calculator();
                CalculatorAdvanced calculatoradvanced = new CalculatorAdvanced();
                FunctionCalculator function = new FunctionCalculator();

                string operation = Convert.ToString(function.Function());

                Console.WriteLine("Podaj dwie liczby: ");
                int argument1 = Convert.ToInt32(Console.ReadLine());
                int argument2 = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case "1":
                        Console.WriteLine(calculator.Adding(argument1, argument2));
                        break;
                    case "2":
                        Console.WriteLine(calculator.Subtraction(argument1, argument2));
                        break;
                    case "3":
                        Console.WriteLine(calculator.Multiplication(argument1, argument2));
                        break;
                    case "4":
                        Console.WriteLine(calculator.Division(argument1, argument2));
                        break;
                    case "5":
                        Console.WriteLine(calculatoradvanced.PrimeNumbers());
                        break;
                    case "6":
                        Console.WriteLine(calculatoradvanced.Factorial());
                        break;
                    case "7":
                        Console.WriteLine(calculatoradvanced.PerfectNumber());
                        break;
                    case "8":
                        Console.WriteLine(calculator.ToThePower(argument1, argument2));
                        break;
                    case "9":
                        Console.WriteLine(calculatoradvanced.AverageNumberFromTheTable());
                        break;
                    case "0":
                        Console.WriteLine(calculatoradvanced.MaximumValueFromTheTable());
                        break;
                    case "*":
                        Console.WriteLine(calculatoradvanced.MinimumValueFromTheTable());
                        break;
                    default:
                        Console.WriteLine("Wrong operation!");
                        break;
                }

                Console.ReadLine();



                

            }

        }
    }
}
