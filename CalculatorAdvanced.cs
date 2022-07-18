using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class CalculatorAdvanced
    {
        public bool PrimeNumbers(int argument1)
        {
            for (int i = 2; i < argument1; i++)
            {
                if (argument1 % i == 0)
                {
                    return false;
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            return true;
        }
        public int Factorial(int argument1)
        {
            int strong = 1;
            Console.WriteLine("Podaj liczbę: ");


            for (int i = 1; i <= argument1; i++)
                strong*=i;
            return strong;
        }
        public bool PerfectNumber(int argument1)
        {
            int n = 0;
            int suma = 0;
            for (int i = 1; i <= n/2; i++)
                if (n % i == 0)
                    suma += i;
            return (suma == n);
        }
        public double AverageNumberFromTheTable(int argument1)
        {
            double srednia = 0;
            double suma = 0;
            Console.WriteLine("Podaj ilość elementów w tablicy: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczby");
            int[] tablica = new int[a];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tablica.Length; i++)
            {
                suma += tablica[i];
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            srednia = suma / a;

            return srednia;
        }
        public double MaximumValueFromTheTable()
        {
            int max = 0;
            Console.WriteLine("Podaj ilość elementów w tablicy:");
            int a = int.Parse(Console.ReadLine());
            int[] tablica = new int[a];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tablica.Length; i++)
            {
                if (max < tablica[i])
                {
                    max = tablica[i];
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            return max;
        }
        public double MinimumValueFromTheTable()
        {
            int min = 0;
            Console.WriteLine("Podaj ilość elementów w tablicy:");
            int a = int.Parse(Console.ReadLine());
            int[] tablica = new int[a];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tablica.Length; i++)
            {
                if (min < tablica[i])
                {
                    min = tablica[i];
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return min;
        }
    }
}
