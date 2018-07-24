using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsExample
{
    class Rect:Shapes

    {
        int len, brd;
        public override void DisplayShapes()
        {
            base.DisplayShapes();
            Console.WriteLine("Rectangle class");

        }

        public override void DisplayArea()
        {
            len = 200;
            brd = 50;
            area = len * brd;
            Console.WriteLine("Area:"+ area);
        }
    }
}
