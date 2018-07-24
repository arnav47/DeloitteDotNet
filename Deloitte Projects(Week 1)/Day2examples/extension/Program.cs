using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine(c.Add(420, 80));

            Console.WriteLine(c.mul(5 , 4));

        }
    }
}
