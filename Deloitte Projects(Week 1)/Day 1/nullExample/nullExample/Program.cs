using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullExample
{
    class Program
    {
        static void Main(string[] args)
        {

            int? age = 32;
            double? pi = null;

            if(age.HasValue)
            {
                Console.WriteLine(age.Value);
            }
            else
                Console.WriteLine("Null!");

            if (pi.HasValue)
            {
                Console.WriteLine(pi.Value);
            }
            else
                Console.WriteLine("Null!");
        }
    }
}
