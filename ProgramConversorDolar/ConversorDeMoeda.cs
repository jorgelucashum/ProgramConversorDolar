using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConversorDolar
{
    class ConversorDeMoeda
    {
        public static double IoF = 6;
        public static double Conversor(double cot, double quant)
        {
            double total = quant * cot;
            return total + (total * IoF / 100);
           
        }


    }
}
