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

                string action = Convert.ToString(function.Action());
                string operation = Convert.ToString(function.Function());
                double result = 0;
                Console.WriteLine("Podaj dwie liczby: ");
                int argument1 = Convert.ToInt32(Console.ReadLine());
                int argument2 = Convert.ToInt32(Console.ReadLine());

                if (action == "1")
                {
                    switch (operation)
                    {
                        case "1":
                            result = calculator.Adding(argument1, argument2);
                            ColorsInformations.WriteColorLine(result, ConsoleColor.Green);
                            break;
                        case "2":
                            result = calculator.Subtraction(argument1, argument2);
                            ColorsInformations.WriteColorLine(result, ConsoleColor.Blue);
                            break;
                        case "3":
                            result = calculator.Multiplication(argument1, argument2);
                            ColorsInformations.WriteColorLine(result, ConsoleColor.Yellow);
                            break;
                        case "4":
                            result = calculator.Division(argument1, argument2);
                            ColorsInformations.WriteColorLine(result, ConsoleColor.Magenta);
                            break;
                        case "5":
                            Console.WriteLine(calculator.ToThePower(argument1, argument2));
                            break;
                    }
                }
                else if (action == "2")
                {
                    switch (operation)
                    {
                        case "6":
                            Console.WriteLine(calculatoradvanced.PrimeNumbers(argument1));
                            break;
                        case "7":
                            Console.WriteLine(calculatoradvanced.PerfectNumber(argument1));
                            break;
                        case "8":
                            Console.WriteLine(calculatoradvanced.Factorial(argument1));
                            break;
                        case "9":
                            Console.WriteLine(calculatoradvanced.AverageNumberFromTheTable(argument1));
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
                }
                //switch (operation)
                //{
                //    case "1":
                //        result = calculator.Adding(argument1, argument2);
                //        ColorsInformations.WriteColorLine(result, ConsoleColor.Green);
                //        break;
                //    case "2":
                //        result = calculator.Subtraction(argument1, argument2);
                //        ColorsInformations.WriteColorLine(result, ConsoleColor.Blue);
                //        break;
                //    case "3":
                //        result = calculator.Multiplication(argument1, argument2);
                //        ColorsInformations.WriteColorLine(result, ConsoleColor.Yellow);
                //        break;
                //    case "4":
                //        result = calculator.Division(argument1, argument2);
                //        ColorsInformations.WriteColorLine(result, ConsoleColor.Magenta);
                //        break;
                //    case "5":
                //        Console.WriteLine(calculator.ToThePower(argument1, argument2));
                //        break;
                //    case "6":
                //        Console.WriteLine(calculatoradvanced.PrimeNumbers(argument1));
                //        break;
                //    case "7":
                //        Console.WriteLine(calculatoradvanced.PerfectNumber(argument1));
                //        break;
                //    case "8":
                //        Console.WriteLine(calculatoradvanced.Factorial(argument1));
                //        break;
                //    case "9":
                //        Console.WriteLine(calculatoradvanced.AverageNumberFromTheTable(argument1));
                //        break;
                //    case "0":
                //        Console.WriteLine(calculatoradvanced.MaximumValueFromTheTable());
                //        break;
                //    case "*":
                //        Console.WriteLine(calculatoradvanced.MinimumValueFromTheTable());
                //        break;
                //    default:
                //        Console.WriteLine("Wrong operation!");
                //        break;
                //}

                Console.ReadLine();


                

            }

        }
    }
}
