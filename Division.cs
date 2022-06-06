using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Division
    {
        public double div()
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            if (b == 0 || a == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0");
                return 0;
            }

            return a / b; //dlaczego wywala mi inta? 
        }
    }
}
