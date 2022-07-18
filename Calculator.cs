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
            //Console.ForegroundColor = ConsoleColor.Green;
            return arument1 + argument2;
        }
        public int Subtraction(int arument1, int argument2)
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            return arument1 - argument2;
        }
        public double Division(int arument1, int argument2)
        {

            if (argument2 == 0 || arument1 == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0");
                return 0;
            }
            //Console.ForegroundColor = ConsoleColor.Yellow;
            return (double) arument1 / argument2;
        }
        public int Multiplication(int arument1, int argument2)
        {
            return arument1 * argument2;
        }

        public int ToThePower(int arument1, int argument2)
        {
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            return (int)Math.Pow(arument1,argument2);

        }
    }
}

