using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            try
            {
                if (a == "Deloitte Training")
                {
                    Console.WriteLine("String is correct");

                }
                else
                {
                    throw (new nomatchexception("message"));
                }



            }

            catch (nomatchexception oex)
            {
                Console.WriteLine(oex.Message.ToString());
                Console.ReadLine();

            }
        }


    }
}



  

