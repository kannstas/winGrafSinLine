using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinGrafSinLine
{
    internal class Operation
    {

        public static double SummSin( int x, double firstNumber, double secondNumber )
        {
            double result;
            return  result = Math.Sin(x*firstNumber) + Math.Sin(x*secondNumber);
        }
    }
}
