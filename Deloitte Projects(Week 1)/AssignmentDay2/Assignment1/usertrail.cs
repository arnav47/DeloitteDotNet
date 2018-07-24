using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class usertrail
    {
        int val1, val2;

        public void show(int v1,int v2)
        {
           
            if(v1>=0)
            {
                Console.WriteLine("V1 > 0");
            }

            else if (v1<0)
            {
                Console.WriteLine("V1 <0");
                throw new Exception("Value less than zero");
                
                

            }

            if (v2 >= 0)
            {
                Console.WriteLine("V2 > 0");
            }

            else if (v2 < 0)
            {
                Console.WriteLine("V2 <0");
              
                throw new Exception("Value less than zero");
            }
        }

        public void calculate(int v1,int v2)
        {

            int a = (v1 - v2);

            if (a >= 0)
            {
                Console.WriteLine("answer is > 0");
            }

            else if (a< 0)
            {
                Console.WriteLine("V1-v2 <0");
                throw new Exception("answer less than zero");
            }
        }


    }
}
