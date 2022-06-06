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
            string op;

            Multiply multiply = new Multiply();
            Add add = new Add();
            Subtraction subtraction = new Subtraction();
            Division division = new Division();
            PierwszaLiczba pierwszaLiczba = new PierwszaLiczba();
            Console.WriteLine("Wybierz działanie: \n" + "(+) :dodawanie \n" + "(-) :odejmowanie \n" + "(*) : mnożenie \n" + "(/) : dzielenie \n" + "l - liczby pierwsze" );
            op = Console.ReadLine();
            Console.WriteLine("Wpisz dwie dowolne liczby: ");
           

            if (op == "+")
            {
                Console.WriteLine(add.add());
            }
            else if (op == "-")
            {
                Console.WriteLine(subtraction.subtr());
            }
            else if (op == "*")
            {
                Console.WriteLine(multiply.multiply());
            }
            else if (op == "/")
                    {
                Console.WriteLine(division.div());
            }
            else if (op == "l")
            {
                Console.WriteLine(pierwszaLiczba.pierwsza());
            } 

            Console.ReadLine();

        }
    }
}
