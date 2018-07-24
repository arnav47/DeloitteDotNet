using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 200;
            string str1 = "Hello";
            string str2 = "World";

            SwapExample<int> intobj = new SwapExample<int>();
            intobj.Swap(ref num1, ref num2);

            Console.WriteLine("After swap : " +num1 + "  " + num2);

            SwapExample<string> intobj2 = new SwapExample<string>();
            intobj2.Swap(ref str1, ref str2);
            Console.WriteLine("After swap : " + str1 + "  " + str2);

        }
    }
}
