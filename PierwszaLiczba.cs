using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class PierwszaLiczba
    {
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
    }
}
