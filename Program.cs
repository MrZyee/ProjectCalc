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
                Console.WriteLine("Wybierz działanie: \n"
                    + "1. Adding \n"
                    + "2. Subtraction \n"
                    + "3. Multiplication \n"
                    + "4. Division \n"
                    + "5. Prime numbers \n"
                    + "6. Factorial \n"
                    + "7. Perfect number\n"
                    + "8. To the power\n"
                    + "9. Average number from the table\n"
                    + "0. Maximum number from the table \n"
                    + "*  Minimum value from the table \n");

                string operation = Console.ReadLine();
                Calculator calculator = new Calculator();

                Console.WriteLine("Podaj dwie liczby: ");
                int argument1 = Convert.ToInt32(Console.ReadLine());
                int argument2 = Convert.ToInt32(Console.ReadLine());


                if (operation == "1")
                {
                    Console.WriteLine(calculator.Adding(argument1, argument2));
                }
                else if (operation == "2")
                {
                    Console.WriteLine(calculator.Subtraction());
                }
                else if (operation == "3")
                {
                    Console.WriteLine(calculator.Multiplication());
                }
                else if (operation == "4")
                {
                    Console.WriteLine(calculator.Division());
                }
                else if (operation == "5")
                {
                    Console.WriteLine(calculator.PrimeNumbers());
                }
                else if (operation == "6")
                {
                    Console.WriteLine(calculator.Factorial());
                }
                else if (operation == "7")
                {
                    Console.WriteLine(calculator.PerfectNumber());
                }
                else if (operation == "8")
                {
                    Console.WriteLine(calculator.ToThePower());
                }
                else if (operation == "9")
                {
                    Console.WriteLine(calculator.AverageNumberFromTheTable());
                }
                else if (operation == "0")
                {
                    Console.WriteLine(calculator.MaximumValueFromTheTable());
                }
                else if (operation == "*")
                {
                    Console.WriteLine(calculator.MinimumValueFromTheTable());
                }

                Console.ReadLine();



                

            }

        }
    }
}
