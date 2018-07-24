using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [DevInfo(EmpID = 123, name = "Deepa", DOC = "07/17/2018", Pname = "Banking", message = "This class calc......div.")]

    class Calculator
        {
            public int add(int x, int y)
            {
                return x + y;
            }
            public int sub(int x, int y)
            {
                return x - y;
            }
            public int mul(int x, int y)
            {
                return x * y;
            }
            public int div(int x, int y)
            {
                return (x / y);
            }
        }
}
