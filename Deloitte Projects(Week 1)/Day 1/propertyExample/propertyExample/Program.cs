using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name and age");
            string n = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

            personinfoauto auto = new personinfoauto();
            auto.Name = n;
            auto.Age = a;


            Console.WriteLine(auto.Name + "    " + auto.Age);

            personInfoCLR clr = new personInfoCLR { Name = "King", Age = 25 };
            Console.WriteLine(clr.Name + "    " + clr.Age);



        }
    }
}
