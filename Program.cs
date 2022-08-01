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

            menu.Show();

            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    {
                        Console.WriteLine("Give two numbers: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        int result = calculator.Adding(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Green);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Give two numbers: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        int result = calculator.Subtraction(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Blue);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Give two numbers: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        int result = calculator.Multiplication(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Yellow);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Give two numbers: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        double doubleResult = calculator.Division(number1, number2);
                        ColorsInformations.WriteColorLine(doubleResult, ConsoleColor.Magenta);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Give two numbers: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        int result = calculatoradvanced.GetPowerOfNumber(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Yellow);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Give one number: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
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
                        Console.WriteLine("Give one number: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        bool GreatNumber = calculatoradvanced.GetGreatNumber(number1);
                        if (GreatNumber)
                        {
                            ColorsInformations.ColorGreatNumber(GreatNumber, ConsoleColor.Green);
                        }
                        else
                        {
                            ColorsInformations.ColorGreatNumber(GreatNumber, ConsoleColor.Red);
                        }
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Give one number: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        int result = calculatoradvanced.GetFactorial(number1);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Magenta);
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Enter the number of elements in the array:: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number: ");
                        int[] tablica = new int[number1];
                        for (int i = 0; i < tablica.Length; i++)
                        {
                            tablica[i] = int.Parse(Console.ReadLine());
                        }
                        double doubleResult = calculatoradvanced.GetAvgFromTable(tablica);
                        Console.WriteLine(doubleResult);
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Enter the number of elements in the array: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number: ");
                        int[] table = new int[number1];
                        for (int i = 0; i < table.Length; i++)
                        {
                            table[i] = int.Parse(Console.ReadLine());
                        }
                        double doubleResult = calculatoradvanced.GetMaxFromTable(table);
                        ColorsInformations.WriteColorLine(doubleResult, ConsoleColor.Magenta);
                        break;
                    }
                case 11:
                    {

                        Console.WriteLine("Enter the number of elements in the array: ");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number: ");
                        int[] table = new int[number1];
                        for (int i = 0; i < table.Length; i++)
                        {
                            table[i] = int.Parse(Console.ReadLine());
                        }
                        double doubleResult = calculatoradvanced.GetMinFromTable(table);
                        ColorsInformations.WriteColorLine(doubleResult, ConsoleColor.Cyan);
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
