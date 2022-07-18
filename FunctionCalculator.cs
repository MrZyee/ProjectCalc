using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class FunctionCalculator
    {
        public string Action()
        {
            Console.WriteLine("Select the calculator level: \n" 
               + "1. Basic:\n " 
               + "Adding\n "
               + "Substraction\n " 
               + "Multiplication\n " 
               + "Division\n "
               + "To the power\n"
               + "2. Advanced:\n " 
               + "Prime numbers \n " 
               + "Perfect number\n " 
               + "Factorial \n " 
               + "Average number from the table\n " 
               + "Maximum number from the table \n " 
               + "Minimum value from the table \n");
            string action = Convert.ToString(Console.ReadLine());
            return action;
        }
       public int Function()
        {
            FunctionCalculator function = new FunctionCalculator();
            string action = function.Action();
            Console.WriteLine("Choose an action: \n");
            if (action == "1")
            {
                Console.WriteLine("1. Adding \n"
                    + "2. Subtraction \n"
                    + "3. Multiplication \n"
                    + "4. Division \n"
                    + "5. To the power\n");
            }
            else if (action == "2")
            {
                Console.WriteLine("6. Prime numbers \n"
                    + "7. Perfect number\n"
                    + "8. Factorial \n"
                    + "9. Average number from the table\n"
                    + "0. Maximum number from the table \n"
                    + "*  Minimum value from the table \n");
            }

            int operation = Convert.ToInt32(Console.ReadLine());
            return operation;
        }
    }
}
