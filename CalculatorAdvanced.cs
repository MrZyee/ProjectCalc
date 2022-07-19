using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class CalculatorAdvanced
    {
        public bool GetPrimeNumbers(int value1)
        {
            for (int i = 2; i < value1; i++)
            {
                if (value1 % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int GetFactorial(int value1)
        {
            int strong = 1;

            for (int i = 1; i <= value1; i++)
                strong*=i;
            return strong;
        }

        public bool GetGreatNumber(int value1)
        {
            int suma = 0;
            for (int i = 1; i <= value1/2; i++)
                if (value1 % i == 0)
                    suma += i;
            return (suma == value1);
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
