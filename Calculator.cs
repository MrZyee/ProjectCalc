using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Calculator
    {
        public int Adding(int arument1 ,int argument2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return arument1 + argument2;
        }
        public double Subtraction()
        {
            Console.WriteLine("Podaj dwie liczby");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            return a - b;
        }
        public double Division()
        {
            Console.WriteLine("Podaj dwie liczby");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            if (b == 0 || a == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0");
                return 0;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            return a / (b * 1.0);
        }
        public double Multiplication()
        {
            Console.WriteLine("Podaj dwie liczby");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            return a * b;
        }
        public bool PrimeNumbers()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            return true;
        }

        public int Factorial()
        {
            int liczba, silnia = 1;
            Console.WriteLine("Podaj liczbę: ");
            liczba = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczba; i++)
                silnia*=i;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return silnia;
        }
        public bool PerfectNumber()
        {
            int n = 0;
            int suma = 0;
            for (int i = 1; i <= n/2; i++)
                if (n % i == 0)
                    suma += i;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            return (suma == n);
        }
        public int ToThePower()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            return a ^ b;

        }
        public double AverageNumberFromTheTable()
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

