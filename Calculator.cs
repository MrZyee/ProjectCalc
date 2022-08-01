using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Calculator
    {
        public int Adding(int value1, int value2) => value1 + value2;
        public int Subtraction(int value1, int value2) => value1 - value2;
        public double Division(int value1, int value2) => (double)value1 / value2;
        public int Multiplication(int value1, int value2) => value1 * value2;
        
    }
}

