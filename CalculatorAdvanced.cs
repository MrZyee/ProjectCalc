using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class CalculatorAdvanced
    {
        public bool GetPrimeNumbers(int argument1)
        {
            for (int i = 2; i < argument1; i++)
            {
                if (argument1 % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int GetFactorial(int argument1)
        {
            int strong = 1;

            for (int i = 1; i <= argument1; i++)
                strong*=i;
            return strong;
        }

        public bool GreatNumber(int argument1)
        {
            int n = 0;
            int suma = 0;
            for (int i = 1; i <= n/2; i++)
                if (n % i == 0)
                    suma += i;
            return (suma == n);
        }

        public double GetAvgFromTable(int[] array)
        {
            double suma = 0;        
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            return suma / array.Length;
        }

        public double GetMaxFromTable(int[] array)
        {
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
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
