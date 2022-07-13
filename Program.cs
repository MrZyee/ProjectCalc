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


                if (operation == "1")
                {
                    Console.WriteLine(calculator.Adding(argument1, argument2));
                }
                else if (operation == "2")
                {
                    Console.WriteLine(calculator.Subtraction(argument1, argument2));
                }
                else if (operation == "3")
                {
                    Console.WriteLine(calculator.Multiplication(argument1, argument2));
                }
                else if (operation == "4")
                {
                    Console.WriteLine(calculator.Division(argument1, argument2));
                }
                else if (operation == "5")
                {
                    Console.WriteLine(calculatoradvanced.PrimeNumbers());
                }
                else if (operation == "6")
                {
                    Console.WriteLine(calculatoradvanced.Factorial());
                }
                else if (operation == "7")
                {
                    Console.WriteLine(calculatoradvanced.PerfectNumber());
                }
                else if (operation == "8")
                {
                    Console.WriteLine(calculator.ToThePower(argument1, argument2));
                }
                else if (operation == "9")
                {
                    Console.WriteLine(calculatoradvanced.AverageNumberFromTheTable());
                }
                else if (operation == "0")
                {
                    Console.WriteLine(calculatoradvanced.MaximumValueFromTheTable());
                }
                else if (operation == "*")
                {
                    Console.WriteLine(calculatoradvanced.MinimumValueFromTheTable());
                }

                Console.ReadLine();



                

            }

        }
    }
}
