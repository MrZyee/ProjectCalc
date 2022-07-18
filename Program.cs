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

            Calculator calculator = new Calculator();
            CalculatorAdvanced calculatoradvanced = new CalculatorAdvanced();
            Menu menu = new Menu();
            int number1, number2, result;
            double doubleResult;

            menu.Show();


            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    {
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        result = calculator.Adding(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Green);
                        break;
                    }
                case 2:
                    {
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        result = calculator.Subtraction(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Blue);
                        break;
                    }
                case 3:
                    {
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        result = calculator.Multiplication(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Yellow);
                        break;
                    }
                case 4:
                    {
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        doubleResult = calculator.Division(number1, number2);
                        ColorsInformations.WriteColorLine(doubleResult, ConsoleColor.Magenta);
                        break;
                    }
                case 6:
                    {
                        number1 = Convert.ToInt32(Console.ReadLine());
                        bool isPrime = calculatoradvanced.GetPrimeNumbers(number1);
                        if (isPrime)
                        {
                            Console.WriteLine(isPrime);
                        }
                        else
                        {
                            Console.WriteLine(isPrime);
                        }
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Podaj ilość elementów w tablicy: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczby");
                        int[] tablica = new int[number1];
                        for (int i = 0; i < tablica.Length; i++)
                        {
                            tablica[i] = int.Parse(Console.ReadLine());
                        }
                        doubleResult = calculatoradvanced.GetAvgFromTable(tablica);
                        Console.WriteLine(doubleResult);
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
