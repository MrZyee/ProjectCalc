using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal static class ColorsInformations
    {
       public static void WriteColorLine(double result,ConsoleColor color)
        {
           Console.ForegroundColor = color;
           Console.WriteLine(result);
           Console.ResetColor();
        }
    }
}
