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
                        int number1, number2, result;
                        Console.WriteLine("Give two numbers: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        result = calculator.Adding(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Green);
                        break;
                    }
                case 2:
                    {
                        int number1, number2, result;
                        Console.WriteLine("Give two numbers: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        result = calculator.Subtraction(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Blue);
                        break;
                    }
                case 3:
                    {
                        int number1, number2, result;
                        Console.WriteLine("Give two numbers: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        result = calculator.Multiplication(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Yellow);
                        break;
                    }
                case 4:
                    {
                        int number1, number2;
                        double doubleResult;
                        Console.WriteLine("Give two numbers: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        doubleResult = calculator.Division(number1, number2);
                        ColorsInformations.WriteColorLine(doubleResult, ConsoleColor.Magenta);
                        break;
                    }
                case 5:
                    {
                        int number1, number2, result;
                        Console.WriteLine("Give two numbers: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        result = calculatoradvanced.GetPowerOfNumber(number1, number2);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Yellow);
                        break;
                    }
                case 6:
                    {
                        int number1;
                        Console.WriteLine("Give one number: ");
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
                        int number1;
                        bool GreatNumber;
                        Console.WriteLine("Give one number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        GreatNumber = calculatoradvanced.GetGreatNumber(number1);
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
                        int number1, result;
                        Console.WriteLine("Give one number: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        result = calculatoradvanced.GetFactorial(number1);
                        ColorsInformations.WriteColorLine(result, ConsoleColor.Magenta);
                        break;
                    }
                case 9:
                    {
                        int number1;
                        double doubleResult;
                        Console.WriteLine("Enter the number of elements in the array:: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number: ");
                        int[] tablica = new int[number1];
                        for (int i = 0; i < tablica.Length; i++)
                        {
                            tablica[i] = int.Parse(Console.ReadLine());
                        }
                        doubleResult = calculatoradvanced.GetAvgFromTable(tablica);
                        Console.WriteLine(doubleResult);
                        break;
                    }
                case 10:
                    {
                        int number1;
                        double doubleResult;
                        Console.WriteLine("Enter the number of elements in the array: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number: ");
                        int[] table = new int[number1];
                        for (int i = 0; i < table.Length; i++)
                        {
                            table[i] = int.Parse(Console.ReadLine());
                        }
                        doubleResult = calculatoradvanced.GetMaxFromTable(table);
                        ColorsInformations.WriteColorLine(doubleResult, ConsoleColor.Magenta);
                        break;
                    }
                case 11:
                    {
                        int number1;
                        double doubleResult;
                        Console.WriteLine("Enter the number of elements in the array: ");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number: ");
                        int[] table = new int[number1];
                        for (int i = 0; i < table.Length; i++)
                        {
                            table[i] = int.Parse(Console.ReadLine());
                        }
                        doubleResult = calculatoradvanced.GetMinFromTable(table);
                        ColorsInformations.WriteColorLine(doubleResult, ConsoleColor.Cyan);
                        break;
                    }
            }
            Console.ReadLine();
        }


    }
}
