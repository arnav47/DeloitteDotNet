using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            int v1 = 5;
            int v2 = 15;

            usertrail ob = new usertrail();

            try
            {
                ob.show(v1, v2);
                ob.calculate(v1, v2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);                                               
            }
           
        }
    }
}
