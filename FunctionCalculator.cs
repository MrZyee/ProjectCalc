using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class FunctionCalculator
    {
       public int Function()
        {

            Console.WriteLine("Wybierz działanie: \n"
                    + "1. Adding \n"
                    + "2. Subtraction \n"
                    + "3. Multiplication \n"
                    + "4. Division \n"
                    + "5. Prime numbers \n"
                    + "6. Factorial \n"
                    + "7. Perfect number\n"
                    + "8. To the power\n"
                    + "9. Average number from the table\n"
                    + "0. Maximum number from the table \n"
                    + "*  Minimum value from the table \n");

            int operation = Convert.ToInt32(Console.ReadLine());
            return operation;
        }
    }
}
