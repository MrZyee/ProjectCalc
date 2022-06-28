using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Calculator
    {
        
        public int add()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }
        public double subtr()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            return a - b;
        }
        public double div()
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            if (b == 0 || a == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0");
                return 0;
            }

            return a / (b * 1.0);
        }
        public double multiply()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            return a * b;
        }
        public bool pierwsza()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int silnia()
        {
            int liczba, silnia = 1;
            Console.WriteLine("Podaj liczbę: ");
            liczba = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczba; i++)
                silnia*=i;

            return silnia;
        }
        public bool doskonala()
        {
            int n = 0;
            int suma = 0;
            for (int i = 1; i <= n/2; i++)
                if (n % i == 0)
                    suma += i;
            return (suma == n);
        }
        public int potega()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            return a ^ b;

        }
        public double srTablica()
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

            srednia = suma / a;

            return srednia;
        }
        public double wartTablicyMax()
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
            return max;
        }
        public double wartTablicyMin()
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
            return min;
        }
    }
}

