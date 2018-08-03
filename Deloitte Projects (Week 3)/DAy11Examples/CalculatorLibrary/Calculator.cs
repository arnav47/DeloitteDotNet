using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator : Icalculator
    {
        public int Add(int x, int y)
        {
            if (x <= 0 || y <= 0)
                throw new ArgumentException("Negative input");
            else
                return (x + y);
        }
        public int Sub(int x, int y)
        {
            if (x < y)
                throw new ArgumentException("Negative answer");
            else if (x <= 0 || y <= 0)
                throw new ArgumentException("Negative input");
            else
                return (x - y);

        }
    }
}
