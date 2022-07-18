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

        public bool GetGreatNumber(int argument1)
        {
            int suma = 0;
            for (int i = 1; i <= argument1/2; i++)
                if (argument1 % i == 0)
                    suma += i;
            return (suma == argument1);
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

        public double GetMinFromTable(int[] array)
        {
            int min = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
