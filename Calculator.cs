using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Calculator
    {
        public double multiply()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            return a * b;
        }
        public double div()
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            if (b == 0 || a == 0)
            {
                return 0;
            }
            return a / (b * 1.0); 
        }
        public double add()
        {
            Console.WriteLine("Wpisz dwie dowolne liczby: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }
        public double subtr()
        {
            Console.WriteLine("Wpisz dwie dowolne liczby: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            return a - b;
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
            Console.WriteLine("Wpisz jedną liczbę: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int silnia = 1;


            for (int i = 1; i <= a; i++)
            {
                silnia*=i;
            }

            return silnia;
        }
        public int potega()
        {
            Console.WriteLine("Podaj podstawę potęgi");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wykładnik");
            int b = Convert.ToInt32(Console.ReadLine());
            return a ^ b;
        }
        public bool doskonala()
        {
            Console.WriteLine("Podaj jedną liczbę");
            int a = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= a/2; i++)
                if (a % i == 0)
                    suma += i;
            Console.WriteLine(suma == a);
            return (suma == a);
        }
        public double sredniatablica()
        {
            double srednia = 0;
            double suma = 0;
            Console.WriteLine("Podaj ilość elementów w tablicy");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczby które mają być w tablicy");
            double[] tablica = new double[a];

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
    }
}
