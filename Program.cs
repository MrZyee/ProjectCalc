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
                string op;


                Calculator calculator = new Calculator();

                Console.WriteLine("Wybierz działanie: \n"
                    + "(1) :dodawanie \n"
                    + "(2) :odejmowanie \n"
                    + "(3) : mnożenie \n"
                    + "(4) : dzielenie \n"
                    + "(5) - liczby pierwsze\n"
                    + "(6) - silnia\n"
                    + "(7) - liczba doskonała\n"
                    + "(8) - potęga\n"
                    + "(9) - średnia liczba z tablicy\n"
                    + "(0) - max i min z tablicy ");
                op = Console.ReadLine();


                if (op == "1")
                {
                    Console.WriteLine(calculator.add());
                }
                else if (op == "2")
                {
                    Console.WriteLine(calculator.subtr());
                }
                else if (op == "3")
                {
                    Console.WriteLine(calculator.multiply());
                }
                else if (op == "4")
                {
                    Console.WriteLine(calculator.div());
                }
                else if (op == "5")
                {
                    Console.WriteLine(calculator.pierwsza());
                }
                else if (op == "6")
                {
                    Console.WriteLine(calculator.silnia());
                }
                else if (op == "7")
                {
                    Console.WriteLine(calculator.doskonala());
                }
                else if (op == "8")
                {
                    Console.WriteLine(calculator.potega());
                }
                else if (op == "9")
                {
                    Console.WriteLine(calculator.srTablica());
                }
                //else if (op == "0")
                //{
                //    Console.WriteLine(calculator.wartTablicy());
                //}

                Console.ReadLine();

            }

        }
    }
}
