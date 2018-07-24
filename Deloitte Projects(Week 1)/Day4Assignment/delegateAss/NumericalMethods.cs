using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateAss
{
    class NumericalMethods
    {
        int intvalue;
        decimal DecimalValue;
        int evalue;

        public void PrintNumber(int number)
        {
            intvalue = number;
            Console.WriteLine("Value: " + intvalue.ToString("N1", CultureInfo.InvariantCulture));
        }

        public void PrintMoney(int number)
        {
            DecimalValue = number;
            Console.WriteLine("Amount: " + DecimalValue.ToString("C", CultureInfo.CurrentCulture));
        }

        public void PrintHexaDecimal(int number)
        {
            evalue = number;
            Console.WriteLine("Hexadecimal: " + evalue.ToString("X"));
        }
    }
}
