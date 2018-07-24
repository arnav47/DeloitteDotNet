using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of a square with side = 25");
            area sq = new area();
            Console.WriteLine(sq.getArea(25));


            Console.WriteLine("Area of a rectangle with side = 20 and 15");
            area sq2 = new area();
            Console.WriteLine(sq2.getArea(20,15));



            Console.WriteLine("Area of a triangle with h=10 and b=5");
            area sq3 = new area();
            Console.WriteLine(sq3.getArea(10.0f,5.0f));



            Console.WriteLine("Area of a circle radius = 10");
            area sq4 = new area();
            Console.WriteLine(sq4.getArea(10.0f));

        }
    }
}
