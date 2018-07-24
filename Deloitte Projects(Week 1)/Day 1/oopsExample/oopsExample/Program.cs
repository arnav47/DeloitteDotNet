using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 p1 = new Class1();
            // p1.GetData();
            // p1.ShowData();

            //Class1 p2 = new Class1();
            //  p2.ShowData();

            // Class1 p3 = new Class1("Blake",59,"Boi@Boi.com");
            // p3.ShowData();


            ///Shapes s = new Rect();
            // s.DisplayArea();
            //  s.DisplayShapes();

            Bird b = new Bird();
            b.fly();

            Kite k = new Kite();
            k.fly();

            Plane p = new Plane();
            p.fly();
            p.PrintTicket();




        }
    }
}
