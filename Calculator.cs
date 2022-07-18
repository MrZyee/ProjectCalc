using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Calculator
    {
        public int Adding(int arument1, int argument2) => arument1 + argument2;
        public int Subtraction(int arument1, int argument2) => arument1 - argument2;
        public double Division(int arument1, int argument2) => (double)arument1 / argument2;
        public int Multiplication(int arument1, int argument2) => arument1 * argument2;
        public int ToThePower(int arument1, int argument2) => (int)Math.Pow(arument1, argument2);
    }
}

