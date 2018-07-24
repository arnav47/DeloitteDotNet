using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateAss
{
    class Program

    {
        public delegate void Num(int m);

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number");
            n = int.Parse(Console.ReadLine());
            NumericalMethods nm = new NumericalMethods();
            Num nme = nm.PrintNumber;

        }
    }
}
